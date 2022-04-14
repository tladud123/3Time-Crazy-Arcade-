using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    // ��ź ��
    public int maxBomb = 5;
    public int minBomb = 1;
    public int maxPower = 5;
    public int minPower = 1;
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
        
        if (minBomb != 0)
        {
            //��ź ��ġ�� �ݿø� �Ͽ� ����**�������� �����ֽ� �κ� ����Ұ�**
            Vector3 createPosition = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y), Mathf.RoundToInt(transform.position.z));
            GameObject bomb = Instantiate(bombObj, createPosition, transform.rotation);
            minBomb -= 1;
            //3�ʵ� ��ź ��ȯ �Լ� ����
            Invoke ("BombReturn", 3f);
        }
        
    }
    //��ź�� ������ �ּ� ��ź�� ��ȯ
    public void BombReturn()
    {
        minBomb += 1;
    }

    //������ �浹�� �ּ� ��ź ���� ����
    public void Bombcount()
    {
        if (minBomb < maxBomb)
        {
            minBomb +=1;
            Debug.Log("��ǳ�� ���� ���� :"+minBomb);
        }
    }
    //������ �浹�� �ּ� ��ź �Ŀ� ����
    public void BombPower()
    {
        if (minPower < maxPower)
        {
            minPower+=1;
            Debug.Log("��ǳ�� �Ŀ� :"+minPower);
        }
        if (minPower == maxPower)
        {
            Debug.Log("��ǳ�� �Ŀ� �ִ�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
