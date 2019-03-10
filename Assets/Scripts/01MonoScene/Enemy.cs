using UnityEngine;
namespace Mono
{
    public class Enemy : MonoBehaviour
    {
        private EnemySpawn spawn;
        private float speed;
        private Player player;
        private float radius;
        private float playerRadius;

        //预留接口
        public void Init(EnemySpawn spawn, float speed, Player player)
        {
            this.spawn = spawn;
            this.speed = speed;
            this.player = player;
        }

        void Start()
        {
            Renderer renderer = GetComponent<Renderer>();
            Renderer playerRenderer = player.GetComponent<Renderer>();
            radius = renderer.bounds.size.x / 2;
            playerRadius = playerRenderer.bounds.size.x / 2;
        }

        void Update()
        {
            //敌人寻路
            Vector3 vector = (player.transform.position - transform.position).normalized *
                Time.deltaTime * speed;
            transform.position += vector;
            //碰撞检测
            float distance = (player.transform.position - transform.position).magnitude;
            if (distance < radius + playerRadius && !player.Dead)
            {
                Destroy(gameObject);
                spawn.EnemyCount--;
            }
        }
    }
}
