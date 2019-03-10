using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace ECSWithJob
{
    public class EnemyMoveSystem : JobComponentSystem
    {
        ComponentGroup enemyGroup;   //由一系列组件组成
        ComponentGroup playerGroup;

        protected override void OnCreateManager() //系统创建时调用
        {
            //声明该组所需的组件，包括读写依赖
            enemyGroup = GetComponentGroup
            (
                ComponentType.ReadOnly(typeof(Velocity)),
                ComponentType.ReadOnly(typeof(EnemyComponent)),
                typeof(Position)
            );
            playerGroup = GetComponentGroup
            (
                ComponentType.ReadOnly(typeof(PlayerInput)),
                ComponentType.ReadOnly(typeof(Position))
            );
        }

        [BurstCompile] //使用Burst编译
        struct EnemyMoveJob : IJobParallelFor //继承该接口实现并行
        {
            public float deltaTime;
            public float3 playerPos;
            //记得声明读写关系
            public ComponentDataArray<Position> positions;
            [ReadOnly] public ComponentDataArray<Velocity> velocities;

            public void Execute(int i) //会被不同的线程调用，所以方法中不能存在引用类型。
            {
                //Read
                float3 position = positions[i].Value;
                float speed = velocities[i].Value;
                //算出朝向玩家的向量
                float3 vector = playerPos - position;
                vector = math.normalize(vector);

                float3 newPos = position + vector * speed * deltaTime;
                //Wirte
                positions[i] = new Position { Value = newPos };
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps) //每帧调用
        {
            if (playerGroup.CalculateLength() == 0) //玩家死亡
                return inputDeps;

            float3 playerPos = playerGroup.GetComponentDataArray<Position>()[0].Value;

            EnemyMoveJob job = new EnemyMoveJob
            {
                deltaTime = Time.deltaTime,
                playerPos = playerPos,
                positions = enemyGroup.GetComponentDataArray<Position>(), //声明了组件后，Get时会进行组件的获取
                velocities = enemyGroup.GetComponentDataArray<Velocity>()
            };
            return job.Schedule(enemyGroup.CalculateLength(), 64, inputDeps); //第一个参数意味着每个job.Execute的执行次数
        }
    }
}

