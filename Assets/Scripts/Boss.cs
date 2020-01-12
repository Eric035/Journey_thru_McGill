using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
	public GameObject LoseMessage;
	public GameObject bullets;
	public GameObject melting;
	public GameObject WinMessage;
	public int inc = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 4.0f, 0);
        InvokeRepeating("Fire", 0, 0.7f);
        InvokeRepeating("Melting", 0, 0.36f);
        Destroy (GameObject.Find("Prompt"), 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
    	if(transform.position.y<=110.0f){
        transform.position = new Vector3(0, Camera.main.transform.position.y+6.8f, 0);//Always at the top of the camera within the map.
    	}

    	if(GameObject.Find("Player 1").transform.position.y<inc-5.0f){//Lost the game if run in to the lava.
    		Instantiate(LoseMessage,transform.position,transform.rotation);
    	}
    	Killed();
    }

    void Fire()
    {
    	float randX = Random.Range(-2.0f,2.0f);//Randomly generates around the player.
    	Instantiate(bullets,new Vector3(GameObject.Find("Player 1").transform.position.x, this.transform.position.y, -1)+new Vector3(randX, 0, 0),this.transform.rotation);
    }

    void Melting()//Ground is melting behind.
    {	
    	Instantiate(melting,new Vector3(0, -5.5f, 0)+new Vector3(0, 1.0f, 0)*inc,this.transform.rotation);
    	inc++;
    }

    void Killed(){//Kill the boss.
    	if(GameObject.Find("Player 1").transform.position.x<0.7 && GameObject.Find("Player 1").transform.position.x>-0.7){
    		if(GameObject.Find("Player 1").transform.position.y>109 && GameObject.Find("Player 1").transform.position.y<115){
    			Debug.Log(GameObject.Find("Player 1").transform.position.x);
    			Debug.Log(GameObject.Find("Player 1").transform.position.y);
    			Destroy(gameObject);
    			Instantiate(WinMessage,transform.position,transform.rotation);
    		}
    }
	}
 
}
