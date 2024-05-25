using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptAbrirPortas : MonoBehaviour {


	public GameObject MostrarTela;
	public Transform warpTarget;
	private bool abrir = false;

	void Start () {

		MostrarTela.SetActive (false);

	}

	void Update (){
		if (abrir && Input.GetKeyDown(KeyCode.E)) 
		{

			var PC = GameObject.FindWithTag("Player").gameObject;
			PC.transform.position = warpTarget.position;
			Camera.main.transform.position = warpTarget.position;
		}
	}

	void OnTriggerEnter2D(Collider2D outro)
	{
		if (outro.gameObject.CompareTag ("Player")) 
		{
			abrir = true;
			MostrarTela.SetActive (abrir);
		}

		if (Input.GetKeyDown(KeyCode.E)) 
		{
			outro.gameObject.transform.position = warpTarget.position;
			Camera.main.transform.position = warpTarget.position;
		}
	}
		
	void OnTriggerExit2D(Collider2D outro)
	{
		if(outro.gameObject.CompareTag("Player"))
		{
			abrir = false;
			MostrarTela.SetActive (abrir);
		}
	}
		



}
