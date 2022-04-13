using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    // ��ź ��
    public int maxBomb = 5;
    public int minbomb = 1;
    // ��ź �Ҵ�
    public GameObject bombObj;
    // Ÿ�� ũ�� ��������
    static public float TileSize = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Bombspawn()
    {
        
        if (minbomb != 0)
        {
            //��ź ��ġ�� �ݿø� �Ͽ� ����**�������� �����ֽ� �κ� ����Ұ�**
            Vector3 createPosition = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y), Mathf.RoundToInt(transform.position.z));
            GameObject bomb = Instantiate(bombObj, createPosition, transform.rotation);
            minbomb -= 1;
            //3�ʵ� ��ź ��ȯ �Լ� ����
            Invoke ("BombReturn", 3f);
        }
        
    }
    //��ź�� ������ �ּ� ��ź�� ��ȯ
    public void BombReturn()
    {
        minbomb += 1;
    }

    //������ �浹�� �ּ� ��ź ���� ����
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
