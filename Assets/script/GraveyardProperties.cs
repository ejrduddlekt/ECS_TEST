using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace TMG.Zombies
{
    public struct GraveyardProperties : IComponentData
    {
        public float2 FieldDimensions; // 위치
        public int NumberTombstonesToSpawn; //스폰 포인트 수
        public Entity TombstonePrefab; //프리팹
    }
}