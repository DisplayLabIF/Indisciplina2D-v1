using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D outro)
	{
		if(outro.gameObject.CompareTag("moeda"))
		{
				Destroy(outro.gameObject);
		}

	}
}
