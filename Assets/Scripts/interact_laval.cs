using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact_laval : MonoBehaviour
{
    public GameObject bridge;
    public GameObject stone;
    

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
        if (collision.gameObject.tag == "Rock")
        {
            Destroy(this.gameObject);
            Debug.Log("Destoryed the lava");
            
            stone.SetActive(true);
            bridge.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
