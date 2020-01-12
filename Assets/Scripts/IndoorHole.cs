using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndoorHole : MonoBehaviour
{
    public GameObject newRock;
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
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }else if(collision.gameObject.tag == "Rock")
        {
            Destroy(collision.gameObject);
            Instantiate(newRock, new Vector3(-11.0F, 42.9F, 0), Quaternion.identity);
        }
    }
}
