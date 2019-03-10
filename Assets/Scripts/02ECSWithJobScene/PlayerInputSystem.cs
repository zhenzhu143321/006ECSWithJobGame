using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace ECSWithJob
{
    public class PlayerInputSystem : ComponentSystem
    {
        struct Player
        {
            public readonly int Length;
            public ComponentDataArray<PlayerInput> playerInput;
           
        }

        [Inject] Player player; //加上这个标签，Unity会自动注入我们声明的结构中的属性

        protected override void OnUpdate()
        {
            for (int i = 0; i < player.Length; i++)
            {
                float3 normalized = new float3();
                float x = Input.GetAxisRaw("Horizontal");
                float z = Input.GetAxisRaw("Vertical");
                if (x != 0 || z != 0) //注意：直接归一化0向量会导致bug
                    normalized = math.normalize(new float3(x, 0, z));
                player.playerInput[i] = new PlayerInput { Vector = normalized };
               
            }
        }
    }
}

