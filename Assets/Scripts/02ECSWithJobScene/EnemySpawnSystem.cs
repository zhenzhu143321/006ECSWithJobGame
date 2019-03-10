using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using Unity.Rendering;
namespace ECSWithJob
{
    public class EnemySpawnSystem : ComponentSystem
    {
        EntityManager manager;
        RenderMesh enemyLook;
        float timer;

        public void Init(EntityManager manager, RenderMesh enemyLook)
        {
            this.manager = manager;
            this.enemyLook = enemyLook;
            timer = 0;
        }

        struct Player
        {
            public readonly int Length;
            public ComponentDataArray<PlayerInput> playerInputs;
            public ComponentDataArray<Position> positions;
        }

        [Inject] Player player;

        protected override void OnUpdate()
        {
            timer += Time.deltaTime;
            if (timer >= 0.1f)
            {
                timer = 0;
                CreatEnemy();
            }
        }

        void CreatEnemy()
        {
            if (player.Length == 0) //玩家死亡
                return;
            float3 playerPos = player.positions[0].Value;

            for (int i = 0; i < 150; i++)
            {
                Entity entity = manager.CreateEntity();

                int angle = UnityEngine.Random.Range(1, 360);        //在玩家什么角度刷出来
                float distance = UnityEngine.Random.Range(15f, 25f); //距离玩家多远刷出来
                                                         //计算该点的x, y分量
                float z = Mathf.Sin(angle) * distance;
                float x = z / Mathf.Tan(angle);
                float3 positon = new float3(playerPos.x + x, 0.5f, playerPos.z + z);
                //初始化敌人及属性
                manager.AddComponentData(entity, new EnemyComponent { });
                manager.AddComponentData(entity, new Health { Value = 2 });
                manager.AddComponentData(entity, new Position { Value = positon });
                manager.AddComponentData(entity, new Velocity { Value = 2 });
                manager.AddSharedComponentData(entity, enemyLook);
            }
        }
    }

}
