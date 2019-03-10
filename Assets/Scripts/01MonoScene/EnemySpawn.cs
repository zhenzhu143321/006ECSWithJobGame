using UnityEngine;
namespace Mono
{
    public class EnemySpawn : MonoBehaviour
    {
        //[HideInInspector]
        public int EnemyCount;
        [SerializeField]
        private GameObject enemyPrefab;
        private Player player;
        private float cooldown;

        void Start()
        {
            player = GameObject.FindWithTag("Player").GetComponent<Player>();
        }

        void Update()
        {
            if (player.Dead)
                return;
            cooldown += Time.deltaTime;
            if (cooldown >= 0.1f)
            {
                cooldown = 0f;
                Spawn();
            }
        }

        void Spawn()
        {
            Vector3 playerPos = player.transform.position;
            for (int i = 0; i < 50; i++)
            {
                GameObject enemy = Instantiate(enemyPrefab);
                EnemyCount++;

                int angle = Random.Range(1, 360);        //在玩家什么角度刷出来(1-359)
                float distance = Random.Range(15f, 25f); //距离玩家多远刷出来
                                                         //角度与距离确定好之后算一下Enemy的初始坐标
                float z = Mathf.Sin(angle) * distance;
                float x = z / Mathf.Tan(angle);

                enemy.transform.position = new Vector3(playerPos.x + x, 0, playerPos.z + z);
                Enemy enemyScript = enemy.AddComponent<Enemy>();
                enemyScript.Init(this, 2.5f, player);
            }
        }
    }
}
