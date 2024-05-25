using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptGameOver : MonoBehaviour{

	public bool pausado = false;
	public GameObject GameOver;


	// Use this for initialization
	void Start () {

		GameOver.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {



	


	}

	void OnTriggerEnter2D(Collider2D outro)
	{
		if(outro.gameObject.CompareTag("Player"))
		{
				pausado = !pausado;	
		}


		if (pausado) {


			GameOver.SetActive (true);
			Time.timeScale = 0;
		}

		if (!pausado) {

			GameOver.SetActive (false);
			Time.timeScale = 1;

		}
	}


	public void Reiniciar(){

		SceneManager.LoadScene ("Fase2 - Etica");
	}

	public void VoltarMenu(){

		SceneManager.LoadScene ("Menu");
	}

	public void Sair(){

		Application.Quit ();
	}
}
