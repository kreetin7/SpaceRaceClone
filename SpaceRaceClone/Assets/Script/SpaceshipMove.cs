using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INTENT: Move the Left player's Spaceship up and down
//USAGE: Place on Left PC
public class SpaceshipMove : MonoBehaviour
{
	private Vector3 StartPos; //declaring StartPos V3
	
	

	// Use this for initialization
	void Start () {
		StartPos = new Vector3(-5.8f, -5.5f,0); //establish Start Pos
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))//use W to...
		{
			transform.Translate(0,0.12f,0 ); //move up
		}

		if (Input.GetKey(KeyCode.S)) //use S to...
		{
			transform.Translate(0,-0.12f,0); //move down
			
		}
		

		if (transform.position.y > 5.6f) //if player leaves top of game screen
		{
			transform.position = StartPos; //put them back at Start pos
		}
	}
}
