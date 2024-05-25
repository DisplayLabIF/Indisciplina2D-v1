using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarCena : MonoBehaviour {


	public void loadScene(string name){
		SceneManager.LoadScene (name);
	}

	public void quitGame(){
		Application.Quit();
	}
}