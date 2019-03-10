using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Burst;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Collections;

namespace ECSWithJob
{
    [UpdateAfter(typeof(PlayerMoveSystem))] //逻辑上依赖于玩家移动系统，所以声明更新时序
    public class EnemyCollisionSystem : JobComponentSystem
    {
        float playerRadius;
        float enemyRadius;
        public void Init(float playerRadius, float enemyRadius)
        {
            this.playerRadius = playerRadius;
            this.enemyRadius = enemyRadius;
        }

        ComponentGroup enemyGroup;
        ComponentGroup playerGroup;

        protected override void OnCreateManager()
        {
            enemyGroup = GetComponentGroup
            (
                ComponentType.ReadOnly(typeof(EnemyComponent)),
                typeof(Health),
                ComponentType.ReadOnly(typeof(Position))
            );
            playerGroup = GetComponentGroup
            (
                ComponentType.ReadOnly(typeof(PlayerInput)),
                ComponentType.ReadOnly(typeof(Position))
            );
        }

        [BurstCompile]
        struct EnemyCollisionJob : IJobParallelFor
        {
            public int collisionDamage; //碰撞对双方造成的伤害
            public float playerRadius;
            public float enemyRadius;
            public float3 playerPos;
            [ReadOnly] public ComponentDataArray<Position> positions;
            public ComponentDataArray<Health> enemies;

            public void Execute(int i)
            {
                float3 position = positions[i].Value;
                float x = math.abs(position.x - playerPos.x);
                float z = math.abs(position.z - playerPos.z);
                //距离
                float magnitude = math.sqrt(x * x + z * z);
                //圆形碰撞检测
                if (magnitude < playerRadius + enemyRadius)
                {
                    //Read
                    int health = enemies[i].Value;
                    //Write
                    enemies[i] = new Health { Value = health - collisionDamage };
                }
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            if (playerGroup.CalculateLength() == 0) //玩家死亡
                return inputDeps;

            float3 playerPos = playerGroup.GetComponentDataArray<Position>()[0].Value;

            EnemyCollisionJob job = new EnemyCollisionJob
            {
                collisionDamage = 1,
                playerRadius = this.playerRadius,
                enemyRadius = this.enemyRadius,
                playerPos = playerPos,
                positions = enemyGroup.GetComponentDataArray<Position>(),
                enemies = enemyGroup.GetComponentDataArray<Health>()
            };
            return job.Schedule(enemyGroup.CalculateLength(), 64, inputDeps);
        }
    }

}


