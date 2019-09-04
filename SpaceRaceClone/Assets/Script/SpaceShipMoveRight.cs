using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INTENT: Move the Right player's Spaceship up and down
//USAGE: Place on Right PC
public class SpaceShipMoveRight : MonoBehaviour {
    
    private Vector3 StartPos; //declaring StartPos V3
	
	

    // Use this for initialization
    void Start () {
        StartPos = new Vector3(5.8f, -5.5f,0); //establish Start Pos
    }
	
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Keypad8)) //use 8 on the number pad to...
        {
            transform.Translate(0,0.12f,0 ); //move up
        }

        if (Input.GetKey(KeyCode.Keypad2)) //use 2 on the number pad to..
        {
            transform.Translate(0,-0.12f,0); //move down
            
        }
		

        if (transform.position.y > 5.6f) //if the player leaves the game screen
        {
            transform.position = StartPos; //place them at the start position
        }
    }
}
