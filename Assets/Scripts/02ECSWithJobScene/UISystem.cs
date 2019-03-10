using Unity.Entities;
using UnityEngine.UI;

namespace ECSWithJob
{
    public class UISystem : ComponentSystem
    {
        Text enemyCount;

        public void Init(Text enemyCount) => this.enemyCount = enemyCount;

        struct Player
        {
            public readonly int Length;
            public ComponentDataArray<PlayerInput> playerInputs;
        }
        struct Enemy
        {
            public readonly int Length;
            public ComponentDataArray<EnemyComponent> enemies;
        }
        [Inject] Player player;
        [Inject] Enemy enemy;

        protected override void OnUpdate()
        {
            if (player.Length == 0) //玩家死亡
                return;

            enemyCount.text = "敌人数量:" + enemy.Length;
        }
    }
}

