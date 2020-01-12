using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
	public float speedY;
	public GameObject LoseMessage;
    void Start()
    {
    	speedY = 2.3f;
    }

    void Update()
    {
        transform.position += transform.up * -speedY  * Time.deltaTime;
        Lava();
    }

    void Lava()
    {
    	if(GameObject.Find("Player 1").transform.position.x<=-8 || GameObject.Find("Player 1").transform.position.x>=8){//Lava on the sides.
    		Instantiate(LoseMessage,transform.position,transform.rotation);
    	}
    }

    void OnBecameInvisible() {//Destroy the object when it is not in the camera.
        Destroy(gameObject);
    }

   	void OnCollisionEnter2D(Collision2D collision)
     {
        Destroy(gameObject);
     }
}
