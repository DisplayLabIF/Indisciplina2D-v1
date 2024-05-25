using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPause : MonoBehaviour {

	public bool pausado = false;
	public GameObject ImagemPause;

	
	// Update is called once per frame

	void Start(){

		ImagemPause.SetActive (false);
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.P))
		{

			pausado = !pausado;
		}

		if (pausado) {


			ImagemPause.SetActive (true);
			Time.timeScale = 0;
		}

		if(!pausado) {

			ImagemPause.SetActive (false);
			Time.timeScale = 1;
		}
			
	}




	public void Continuar(){

		pausado = false;
	}

	public void Reiniciar(){

		SceneManager.LoadScene ("Fase1 - Responsabilidade");
	}

	public void VoltarMenu(){

		SceneManager.LoadScene ("Menu");
	}

	public void Sair(){

		Application.Quit ();
	}
		
}
