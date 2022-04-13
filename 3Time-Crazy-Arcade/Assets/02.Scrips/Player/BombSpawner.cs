using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    // 폭탄 수
    public int maxBomb = 5;
    public int minbomb = 1;
    // 폭탄 할당
    public GameObject bombObj;
    // 타일 크기 가져오기
    static public float TileSize = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Bombspawn()
    {
        
        if (minbomb != 0)
        {
            //폭탄 위치를 반올림 하여 스폰**선생님이 도와주신 부분 기억할것**
            Vector3 createPosition = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y), Mathf.RoundToInt(transform.position.z));
            GameObject bomb = Instantiate(bombObj, createPosition, transform.rotation);
            minbomb -= 1;
            //3초뒤 폭탄 반환 함수 실행
            Invoke ("BombReturn", 3f);
        }
        
    }
    //폭탄이 터진뒤 최소 폭탄값 반환
    public void BombReturn()
    {
        minbomb += 1;
    }

    //아이템 충돌시 최소 폭탄 갯수 변경
    public void BombCount(int newBombCount)
    {
        if (minbomb < maxBomb)
        {
            minbomb += newBombCount;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
