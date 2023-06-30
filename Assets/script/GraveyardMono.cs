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
        public uint randomSeed; //Random.CreateFromIndex() �޼����� �Ű������� uint Ÿ���̸�, Random ����ü�� �����մϴ�.
                                //���� �õ�(Random Seed)�� ���� ���ڸ� �����ϱ� ���� �ʱⰪ���� ���˴ϴ�.
                                //�̷��� �õ尪�� �����ϸ� ������ ���� ���� �������� �����˴ϴ�.
                                //���� ���, ������ ���带 �����ϴ� ���ӿ��� Ư�� �õ尪�� �̿��ϸ�,
                                //������ ���� �õ带 ����ϴ� ��� �÷��̾�鿡�� ������ ���带 ������ �� �ֽ��ϴ�.
                                //�̷��� ����� �̿��ϸ� ���� �ٸ� �õ� ���� �����ϴ� �پ��� ������ ������ �� �ְ� �˴ϴ�.
    }

    //��ƼƼ �Ҵ�
    public class GraveyardBaker : Baker<GraveyardMono>
    {
        public override void Bake(GraveyardMono authoring)
        {
            var graveyardEntity = GetEntity(TransformUsageFlags.Dynamic);
            //TransformUsageFlags�� GameObject�� Transform ������Ʈ�� ��ƼƼ �����ͷ� ��ȯ�Ǵ� ����� ���� ��� �ϸ�
            //��Ÿ�ӽ� ���ʿ��� ��ȯ ������Ʈ ���� ���̴µ� ������ �ݴϴ�.


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