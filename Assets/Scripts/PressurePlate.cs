using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private bool pressureOn = false;
    private bool lockedDoor = true;
    public Animator doorAnim;
    //public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        pressureOn = true;
        if (pressureOn && collision.gameObject.tag == "Rock")
        {
            Debug.Log("Open door\n");
            doorAnim.SetInteger("Open door", 1);
            

        }
        else if(pressureOn && collision.gameObject.tag == "Player")
        {
            Debug.Log("Open door\n");
            doorAnim.SetInteger("Opened", 1);
        } 
    }

    void OnTriggerStay2D(Collider2D other)
    {
        pressureOn = true;
        Debug.Log("Open door\n");
        doorAnim.SetInteger("Opened", 1);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Close door\n");
        if (other.gameObject.tag == "Player")
        {
            pressureOn = false;
            doorAnim.SetInteger("Opened", 0);
        }
            //Coroutine();

    }
    //IEnumerator Coroutine()
    //{
    //    yield return new WaitForSeconds(2);
    //    doorAnim.SetInteger("Closed", 0);

    //}


}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    bool isStepped = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Rock")
        {
            isStepped = true;
            Debug.Log(isStepped);
            
        }

        //else
        //{
        //    OnState();
        //}
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isStepped = false;
        Debug.Log(isStepped);
    }
}
*/