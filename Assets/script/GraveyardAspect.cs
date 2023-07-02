using TMG.Zombies;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace TMG.Zombies
{
    public readonly partial struct GraveyardAspect : IAspect //Aspect�� ���� ���ؼ� IAspect �������̽��� ��ӹ޾ƾ� �Ѵ�.
    {
        public readonly Entity Entity; //Entity�� ���� ����

        private readonly RefRO<LocalTransform> _transform;
        private LocalTransform Transform => _transform.ValueRO;
        private readonly RefRO<GraveyardProperties> _graveyardProperties;
        private readonly RefRW<GraveyardRandom> _graveyardRandom;
    }
}