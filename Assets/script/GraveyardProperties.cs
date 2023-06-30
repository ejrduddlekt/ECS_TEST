using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace TMG.Zombies
{
    public struct GraveyardProperties : IComponentData
    {
        public float2 FieldDimensions; // ��ġ
        public int NumberTombstonesToSpawn; //���� ����Ʈ ��
        public Entity TombstonePrefab; //������
    }
}