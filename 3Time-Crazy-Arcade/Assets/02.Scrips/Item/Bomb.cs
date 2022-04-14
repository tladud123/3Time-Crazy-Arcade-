using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "Player")
    //    {
    //        BazziController bazziController = collision.GetComponent<BazziController>();
    //        bazziController.inBubble = true;
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        BazziController bazziController = collision.GetComponent<BazziController>();
    //        bazziController.inBubble = false;
    //    }
    //}
}
