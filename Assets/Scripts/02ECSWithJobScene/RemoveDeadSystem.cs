using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

namespace ECSWithJob
{
    public class RemoveDeadBarrier : BarrierSystem
    {
    }
    public class RemoveDeadSystem : JobComponentSystem
    {
        struct Player
        {
            public readonly int Length;
            [ReadOnly] public ComponentDataArray<PlayerInput> PlayerInputs;
        }
        [Inject] Player player;
        [Inject] RemoveDeadBarrier barrier;

        [BurstCompile]
        struct RemoveDeadJob : IJobProcessComponentDataWithEntity<Health>
        {
            public bool PlayerDead;
            public EntityCommandBuffer Command;

            //该方法会获取所有带有Health组件的实体。
            public void Execute(Entity entity, int index, [ReadOnly] ref Health health)
            {
                if (health.Value <= 0 || PlayerDead)
                    Command.DestroyEntity(entity);
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            bool playerDead = player.Length == 0;

            RemoveDeadJob job = new RemoveDeadJob
            {
                PlayerDead = playerDead,
                Command = barrier.CreateCommandBuffer(),
            };
            return job.ScheduleSingle(this, inputDeps); //这里使用ScheduleSingle可以不需要指定Execute的指定顺序。
        }
    }
}

