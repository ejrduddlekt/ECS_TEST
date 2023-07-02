using TMG.Zombies;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace TMG.Zombies
{
    public readonly partial struct GraveyardAspect : IAspect //Aspect를 쓰기 위해선 IAspect 인터페이스를 상속받아야 한다.
    {
        public readonly Entity Entity; //Entity에 대한 참조

        private readonly RefRO<LocalTransform> _transform;
        private LocalTransform Transform => _transform.ValueRO;
        private readonly RefRO<GraveyardProperties> _graveyardProperties;
        private readonly RefRW<GraveyardRandom> _graveyardRandom;
    }
}