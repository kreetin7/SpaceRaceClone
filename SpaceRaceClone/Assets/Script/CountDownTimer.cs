﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CountDownTimer : MonoBehaviour
{

	public int TimeLeft;
	public Text CountDownText; 
	

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(Timer());
		Time.timeScale = 1; 
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		CountDownText.text =("" + TimeLeft); 
	}

	IEnumerator Timer()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			TimeLeft--;
		}
		
	}
}
