using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockDoor : MonoBehaviour
{
    public GameObject player;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y > 17.0f)
        {
            Debug.Log("locked");
            this.anim.SetInteger("Opened", 0);
        }

    }
}
