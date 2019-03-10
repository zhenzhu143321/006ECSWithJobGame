using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace ECSWithJob
{
    public class PlayerMoveSystem : ComponentSystem
    {
        struct Player
        {
            public readonly int Length;
            public ComponentDataArray<Position> positions;
            public ComponentDataArray<PlayerInput> playerInput;
            public ComponentDataArray<Velocity> velocities;
        }

        [Inject] Player player;

        protected override void OnUpdate()
        {
            float deltaTime = Time.deltaTime;
            for (int i = 0; i < player.Length; i++)
            {
                //Read
                Position position = player.positions[i];
                PlayerInput input = player.playerInput[i];
                Velocity velocity = player.velocities[i];

                position.Value += new float3(input.Vector * velocity.Value * deltaTime);
                //Write
                player.positions[i] = position;
            }
        }
    }
}

