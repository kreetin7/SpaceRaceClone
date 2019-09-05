using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//INTENT: Move the Left player's Spaceship up and down
//USAGE: Place on Left PC
public class SpaceshipMove : MonoBehaviour
{
	private Vector3 StartPos; //declaring StartPos V3

	private float Yspeed = 0.12f;

	public int ScoreLeft = 0;
	public Text CounterLeft;

	// Use this for initialization
	void Start () {
		StartPos = new Vector3(-5.8f, -5.5f,0); //establish Start Pos
	}
	
	// Update is called once per frame
	void Update ()
	{

		CounterLeft.text = ("" + ScoreLeft);
		if (Input.GetKey(KeyCode.W))//use W to...
		{
			transform.Translate(0,Yspeed,0 ); //move up
		}

		if (Input.GetKey(KeyCode.S)) //use S to...
		{
			transform.Translate(0,-Yspeed,0); //move down
			
		}
		

		if (transform.position.y > 5.6f) //if player leaves top of game screen
		{
			transform.position = StartPos; //put them back at Start pos
			ScoreLeft++; 
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{

		StartCoroutine(DeathRespawn());
		//Debug.Log("Hit");
	}

	IEnumerator DeathRespawn ()
	{
		Yspeed = 0;
		transform.position = new Vector3(-16f,-16f,0);
		yield return new WaitForSeconds(2f);
		Yspeed = 0.12f;
		transform.position = new Vector3(-5.8f,-4.3f,0f);
		print(transform.position.x);
	}
	
	
}
