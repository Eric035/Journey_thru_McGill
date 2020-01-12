using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // IMPORTANT!!!!!!!!

public class Player3 : MonoBehaviour
{
    public int score = 100;
    public Text scoreText;
    public string grade = "A";
    void Start()
    {
        
    }


    void Update()
    {
    	if(score<85 && score >= 80){
    		grade = "A-";
    	}
    	if(score<80 && score >= 75){
    		grade = "B+";
    	}
    	if(score<75 && score >= 70){
    		grade = "B";
    	}
    	if(score<70 && score >= 65){
    		grade = "B-";
    	}
    	if(score<65 && score >= 60){
    		grade = "C+";
    	}
    	if(score<60 && score >= 55){
    		grade = "C";
    	}
    	if(score<55 && score >= 50){
    		grade = "D";
    	}
    	if(score<50){
    		grade = "F";
    	}
     	scoreText.text = this.score.ToString() + " " + grade;
    }
    void OnCollisionEnter2D(Collision2D collision)
     {
        score = score - 5;
        Debug.Log(score);
     }
}
