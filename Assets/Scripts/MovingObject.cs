using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class MovingObject : MonoBehaviour
{
    public Rigidbody2D rb;

    private bool isMoving = false;
    public float range = 0;
    private float nextX;
    private float nextY;

    private float moveTime;
    public float startMoveTime;


    public float pushMod;

    void Start()
    {
        moveTime = startMoveTime;
    }

    void FixedUpdate()
    {
        if (!isMoving)
        {
            
            nextX = Random.Range(-range, range);
            nextY = Random.Range(-range , range);
            moveTime = startMoveTime;
            isMoving = true;
        }
        else
        {
            if(moveTime <= 0)
            {
                isMoving = false;
            } else
            {
                moveTime -= Time.deltaTime;
                
            }
        }


        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(nextX, nextY);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(nextX * pushMod, nextY * pushMod));


        }
    }
}
