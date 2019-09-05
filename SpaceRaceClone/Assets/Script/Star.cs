using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

	public GameObject StarPrefab;
	
	 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0.01f,0,0);

		if (transform.position.x > 12.5f)
		{
			transform.position = new Vector3(-12f, transform.position.y, 0);
		}
	}

	/*private void OnCollisionEnter2D(Collision2D other)
	{
		//Debug.Log("HitStar");
	}*/
}
