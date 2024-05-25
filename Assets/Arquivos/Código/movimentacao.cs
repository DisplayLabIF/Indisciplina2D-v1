using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour {

	public int moedas = 0;
	public AudioClip coin;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter2D(Collider2D outro)
	{
		if (outro.gameObject.CompareTag ("moeda")) 
		{
			gerenciador.inst.PlayAudio(coin);
			moedas++;
			Destroy (outro.gameObject);

		}
	}
}
