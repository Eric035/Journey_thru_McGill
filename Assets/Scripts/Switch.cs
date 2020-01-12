using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Animator doorAnim;
    public Animator switchAnim;
    private bool lockedDoor = true;
    private bool switchOn = false;
    private int contact = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (!switchOn)
        {
            contact = 1;
            switchOn = true;

            Debug.Log("Switch on\n");
            switchAnim.SetInteger("switchedOn", contact);
            doorAnim.SetInteger("Opened", contact);

            contact--;
        }else if (switchOn)
        {
            switchOn = false;

            Debug.Log("Switch off\n");
            switchAnim.SetInteger("switchedOn", contact);
            doorAnim.SetInteger("Opened", contact);

        }


    }
}
