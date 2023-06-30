using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using Random = Unity.Mathematics.Random;

namespace TMG.Zombies
{
    public class GraveyardMono : MonoBehaviour
    {
        public float2 FieldDimensions;
        public int NumberTombstonesToSpawn;
        public GameObject TombstonePrefab;
        public uint randomSeed; //Random.CreateFromIndex() 메서드의 매개변수는 uint 타입이며, Random 구조체를 생성합니다.
                                //랜덤 시드(Random Seed)는 랜덤 숫자를 생성하기 위한 초기값으로 사용됩니다.
                                //이러한 시드값이 동일하면 동일한 랜덤 숫자 시퀀스가 생성됩니다.
                                //예를 들어, 랜덤한 월드를 생성하는 게임에서 특정 시드값을 이용하면,
                                //동일한 랜덤 시드를 사용하는 모든 플레이어들에게 동일한 월드를 제공할 수 있습니다.
                                //이러한 방식을 이용하면 서로 다른 시드 값이 제공하는 다양한 경험을 공유할 수 있게 됩니다.
    }

    //엔티티 할당
    public class GraveyardBaker : Baker<GraveyardMono>
    {
        public override void Bake(GraveyardMono authoring)
        {
            var graveyardEntity = GetEntity(TransformUsageFlags.Dynamic);
            //TransformUsageFlags는 GameObject의 Transform 컴포넌트가 엔티티 데이터로 변환되는 방법에 대해 제어를 하며
            //런타임시 불필요한 변환 컴포넌트 수를 줄이는데 도움을 줍니다.


            AddComponent(graveyardEntity, new GraveyardProperties
            {
                FieldDimensions = authoring.FieldDimensions,
                NumberTombstonesToSpawn = authoring.NumberTombstonesToSpawn,
                TombstonePrefab = GetEntity(authoring.TombstonePrefab, TransformUsageFlags.Dynamic),
            });
            AddComponent(graveyardEntity, new GraveyardRandom
            {
                Value = Random.CreateFromIndex(authoring.randomSeed),
            });;
        }
    }
}