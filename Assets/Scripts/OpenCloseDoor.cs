using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public Animator anim;
    public bool locked = true;
    public bool doorMechanismExist = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (doorMechanismExist && collision.gameObject.tag == "Player")
        {
            Debug.Log("Open door\n");
            anim.SetInteger("Opened", 1);
            locked = false;
        }
        else if (doorMechanismExist && locked == false)
        {
            Debug.Log("Close door\n");
            StartCoroutine(Coroutine());
        }
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(2);
        anim.SetInteger("Closed", 0);
        this.GetComponent<Collider2D>().enabled = true;
        locked = true;
    }

}