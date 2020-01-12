using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // IMPORTANT!!!!!!!!
 

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
     Debug.Log(GameObject.Find("Player").GetComponent<Player3>().score);
     scoreText.text = "WOCA";//GameObject.Find("Player").GetComponent<Player3>().score.ToString();
    }
   
}
