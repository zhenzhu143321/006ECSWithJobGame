using UnityEngine;
using UnityEngine.UI;
using Unity.Entities;
using Unity.Jobs;
using Unity.Burst;
using Unity.Rendering;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Collections;
using Random = UnityEngine.Random;
namespace ECSWithJob
{
    public struct PlayerInput : IComponentData
    {
        public float3 Vector;
    }

    public struct EnemyComponent : IComponentData
    {
    }

    public struct CameraComponent : IComponentData
    {
    }

    public struct Health : IComponentData
    {
        public int Value;
    }

    public struct Velocity : IComponentData
    {
        public float Value;
    }
}