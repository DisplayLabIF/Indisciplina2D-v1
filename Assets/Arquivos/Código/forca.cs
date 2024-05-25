using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forca : MonoBehaviour {

	public float aplicaforca = 2.5f;
	public Rigidbody2D bola;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
		void Update () {
			
		if (this.gameObject.CompareTag ("bola")) {
			
			if (Input.GetKeyDown (KeyCode.Space)) {

				bola.AddForce (new Vector2 (0, aplicaforca * Time.deltaTime), ForceMode2D.Impulse);
			}	
		}
	}
}
	

						
