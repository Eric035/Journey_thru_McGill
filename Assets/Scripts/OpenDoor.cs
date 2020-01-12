using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator anim;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Open door\n");
            anim.SetInteger("Opened", 1);
            this.GetComponent<Collider2D>().enabled = false;
           
        }
    }
}
