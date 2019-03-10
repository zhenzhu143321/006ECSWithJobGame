using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
namespace ECSWithJob
{
    public class CameraMoveSystem : ComponentSystem
    {
        struct Player
        {
            public readonly int Length;
            public ComponentDataArray<PlayerInput> playerInputs;
            public ComponentDataArray<Position> positions;
        }
        struct Cam
        {
            public ComponentDataArray<CameraComponent> cameras;
            public ComponentArray<Transform> transforms;
        }
        [Inject] Player player;
        [Inject] Cam cam;

        protected override void OnUpdate()
        {
            if (player.Length == 0) //玩家死亡
                return;
            float3 pos = player.positions[0].Value;
            //相机跟随
            cam.transforms[0].position = new Vector3(pos.x, cam.transforms[0].position.y, pos.z);
        }
    }
}

