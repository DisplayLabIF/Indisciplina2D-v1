using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioc : MonoBehaviour {

	public AudioSource musica;

	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.T))
			{
				musica.Play();
			}

		if(Input.GetKeyDown(KeyCode.Y))
		{
			musica.Stop();
		}

		if(Input.GetKeyDown(KeyCode.U))
		{
			musica.Pause();
		}
	}
}
