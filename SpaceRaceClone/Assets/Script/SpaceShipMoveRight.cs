using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI; 

//INTENT: Move the Right player's Spaceship up and down
//USAGE: Place on Right PC
public class SpaceShipMoveRight : MonoBehaviour {
    
    private Vector3 StartPos; //declaring StartPos V3

    private float Yspeed = 0.12f;

    public int ScoreRight = 0;

    public Text RightCounttext;
    
	
	

    // Use this for initialization
    void Start () {
        StartPos = transform.position; //establish Start Pos
    }
	
    // Update is called once per frame
    void Update ()
    {

        RightCounttext.text = ("" + ScoreRight);
        
        if (Input.GetKey(KeyCode.Keypad8)) //use 8 on the number pad to...
        {
            transform.Translate(0,Yspeed,0 ); //move up
        }

        if (Input.GetKey(KeyCode.Keypad2)) //use 2 on the number pad to..
        {
            transform.Translate(0,-Yspeed,0); //move down
            
        }
		

        if (transform.position.y > 5.6f) //if the player leaves the game screen
        {
            transform.position = StartPos; //place them at the start position
            ScoreRight++;
            print(ScoreRight);
        }
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
       StartCoroutine(DeathRespawn2());
       //transform.position = StartPos;
        Debug.Log("Hit");
    }
    
    IEnumerator DeathRespawn2 ()
    {
        Yspeed = 0;
        transform.position = new Vector3(-13f,-13f,0);
        yield return new WaitForSeconds(2f);

        Yspeed = 0.12f;
        //transform.position = new Vector3(5.8f,-4.3f,0f);
        transform.position = new Vector3(5.8f, -4.3f,0);
        print(transform.position.y);
    } 
}
