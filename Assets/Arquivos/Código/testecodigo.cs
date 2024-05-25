using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testecodigo : MonoBehaviour {

	public float velocidade = 0.1f;
	public Renderer quad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (velocidade * Time.deltaTime, 0);
		quad.material.mainTextureOffset += offset;
	}
}
