using TMG.Zombies;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace TMG.Zombies
{
    public readonly partial struct GraveyardAspect : IAspect
    {
        public readonly Entity Entity;

        private readonly RefRO<LocalTransform> _transform;
        private LocalTransform Transform => _transform.ValueRO;
        private readonly RefRO<GraveyardProperties> _graveyardProperties;
        private readonly RefRW<GraveyardRandom> _graveyardRandom;

    }
}

//

//private readonly RefRO<GraveyardProperties> _graveyardProperties;
//

//public int NumberTombstonesToSpawn => _graveyardProperties.ValueRO.NumberTombstonesToSpawn;
//public Entity TombstonePrefab => _graveyardProperties.ValueRO.TombstonePrefab;



//public LocalTransform GetRandomTombstoneTransform()
//{
//    return new LocalTransform
//    {
//        Position = GetRandomPosition(),
//        Rotation = GetRandomRotation(),
//        Scale = GetRandomScale(0.5f)
//    };
//}

//private float3 GetRandomPosition()
//{
//    float3 randomPosition;
//    do
//    {
//        randomPosition = _graveyardRandom.ValueRW.Value.NextFloat3(MinCorner, MaxCorner);
//    } while (math.distancesq(Transform.Position, randomPosition) <= BRAIN_SAFETY_RADIUS_SQ);

//    return randomPosition;
//}

//private float3 MinCorner => Transform.Position - HalfDimensions;
//private float3 MaxCorner => Transform.Position + HalfDimensions;
//private float3 HalfDimensions => new()
//{
//    x = _graveyardProperties.ValueRO.FieldDimensions.x * 0.5f,
//    y = 0f,
//    z = _graveyardProperties.ValueRO.FieldDimensions.y * 0.5f
//};
//private const float BRAIN_SAFETY_RADIUS_SQ = 100;

//private quaternion GetRandomRotation() => quaternion.RotateY(_graveyardRandom.ValueRW.Value.NextFloat(-0.25f, 0.25f));
//private float GetRandomScale(float min) => _graveyardRandom.ValueRW.Value.NextFloat(min, 1f);

//public float2 GetRandomOffset()
//{
//    return _graveyardRandom.ValueRW.Value.NextFloat2();
//}

