using UnityEngine;
using UnityEngine.UI;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;
using Unity.Mathematics;

namespace ECSWithJob
{
    public class BootStrapMain
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void Start()
        {
            EntityManager manager = World.Active.GetOrCreateManager<EntityManager>();

            GameObject player = GameObject.FindWithTag("Player");
            GameObject enemy = GameObject.FindWithTag("Enemy");
            GameObject camera = GameObject.FindWithTag("MainCamera");
            Text enemyCount = GameObject.Find("EnemyCountText").GetComponent<Text>();
            //获取Player MeshInstanceRenderer
            RenderMesh playerRenderer = player.GetComponent<RenderMeshProxy>().Value;
            Object.Destroy(player);
            //获取Enemy MeshInstanceRenderer
            RenderMesh enemyRenderer = enemy.GetComponent<RenderMeshProxy>().Value;
            Object.Destroy(enemy);
            //初始化玩家实体
            Entity entity = manager.CreateEntity();
            manager.AddComponentData(entity, new PlayerInput { });
            manager.AddComponentData(entity, new Position { Value = new float3(0, 0.5f, 0) });
            manager.AddComponentData(entity, new Velocity { Value = 7 });
            manager.AddSharedComponentData(entity, playerRenderer);
            //初始化摄像机实体
            GameObjectEntity gameObjectEntity = camera.AddComponent<GameObjectEntity>();
            manager.AddComponentData(gameObjectEntity.Entity, new CameraComponent());

            //初始化UI系统
            UISystem uISystem = World.Active.GetOrCreateManager<UISystem>();
            uISystem.Init(enemyCount);


            //初始化敌人生成系统
            EnemySpawnSystem enemySpawnSystem = World.Active.GetOrCreateManager<EnemySpawnSystem>();
            enemySpawnSystem.Init(manager, enemyRenderer);

            //初始化敌人碰撞系统
           EnemyCollisionSystem collisionSystem = World.Active.GetOrCreateManager<EnemyCollisionSystem>();
           collisionSystem.Init(playerRenderer.mesh.bounds.size.x / 2, enemyRenderer.mesh.bounds.size.x / 2);
        }
    }
}

