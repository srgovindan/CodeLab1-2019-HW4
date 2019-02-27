using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

	public ParticleSystem Ripples;

	// Use this for initialization
	void Start()
	{
	
	}

	// Update is called once per frame
	void Update()
	{

		// Turn particle effects on/off when primary mouse is clicked
		if (Input.GetMouseButtonDown(0))
		{
			//Debug.Log("Primary mouse was clicked.");
			//Ripples.Play();

		}
	}
}
