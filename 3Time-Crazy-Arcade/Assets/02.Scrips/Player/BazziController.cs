using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazziController : MonoBehaviour
{
    // �÷��̾ �׾��� ��ҳ� = ��� ����
    private bool isDead = false;
    // ����� ������ٵ� ������Ʈ
    private Rigidbody2D playerRigidbody;
    // ����� ����� �ҽ� ������Ʈ
    private AudioSource playerAudio;
    // ����� �ִϸ����� ������Ʈ
    private Animator animator;
    // ���� �ִ� ���ǵ�
    public float maxSpeedBazzi = 5f;
    // ���� �⺻ ���ǵ�
    public float speedBazzi = 2f;
    // ���� �߰� ���ǵ�
    public float minSpeedBazzi = 2f;
    // ��ǳ�� ���� ���ǵ�
    public float hurtSpeed = 0.5f;
    // ĳ���� �ִ� �����
    public int maxLife = 3;
    // ĳ���� �ʱ� �����
    public int life = 3;
    // ��ź ��Ű��Ʈ ����
    public GameObject bomb;

    private bool inBubble = false;
    void Start()
    {
        // �� ���������� �ʱ�ȭ
        // ���� ������Ʈ�κ��� ����� ������Ʈ���� ������ ������ �Ҵ�
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAudio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        //����� �÷��̾ ������ٵ� 2D�� ã�Ƽ� �����´�
        playerRigidbody = GetComponent<Rigidbody2D>();
        // ĳ���� �������� �ִ�� ����
        life = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        // ĳ���� ������� 0���� Ȯ��
        //(���� ��ǳ�� �����°ɷ� ��������)                    ///////////////////////////////////////////////////////////////**********
        if (life == 0)
        {
            if (!isDead)
            {
                
            }
        }
        // �̵� ����
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speedBazzi * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speedBazzi * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speedBazzi * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speedBazzi * Time.deltaTime);
        }
        //Ŭ���� ��ź ��ȯ
        
        if (Input.GetMouseButtonDown(0) && !inBubble)
        {
            bomb.GetComponent<BombSpawner>().Bombspawn();
        }

    }
    void BombSpawn(int newbomb)
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bubble")
        {
            inBubble = true;
        }


        //������ �κ�
        if (collision.tag == "Speed")
        {
            if (speedBazzi < maxSpeedBazzi)
            {
                speedBazzi++;
                minSpeedBazzi++;
            }
        }
        if (collision.tag == "Count")
        {
            bomb.GetComponent<BombSpawner>().Bombcount();
        }
        if (collision.tag == "Power")
        {
            bomb.GetComponent<BombSpawner>().BombPower();
        }
        if (collision.tag == "Life")
        {
            if (life < maxLife)
            {
                life++;
            }
        }
        //���� �� ���ٱ� �浹�κ�
        if(collision.tag== "Enemy")
        {
            Die();
        }
        if (collision.tag == "Water")
        {
            Die();
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Bubble")
        {
            inBubble = false;
        }
    }
    void Die()
    {
        speedBazzi = 0.5f;

    }

}
    

