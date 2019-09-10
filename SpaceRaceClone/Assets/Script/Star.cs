using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

	public GameObject StarPrefab;
	public int NumofCubes;
	public int min, max;

	public Renderer spriteRen;
	public ParticleSystem particles;


	// Use this for initialization
	void Start()
	{
		spriteRen = GetComponent<Renderer>();
		//particlesystem = GetComponentInChildren<ParticleSystem>(); 
		//particlesystem.Pause();
		//particles = transform.GetChild(1).gameObject;
		particles = GetComponentInChildren<ParticleSystem>();

		particles.Stop();

	}

	// Update is called once per frame
		void Update()
		{
			transform.Translate(0.01f, 0, 0);

			if (transform.position.x > 12.5f)
			{
				transform.position = new Vector3(-12f, transform.position.y, 0);
			}


		}

		void OnCollisionEnter2D(Collision2D other)
		{
			gameObject.tag = "DoubleStar";
			spriteRen.material.color = Color.yellow;
			//particlesystem.Play();
			//particles.SetActive(true);

			if (!particles.isPlaying)
			{
				particles.Play();
			}
		}
	}

