using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputs : MonoBehaviour {

	private  int moveEixo;

	public Text t1, t2, t3, t4;

	// Use this for initialization
	void Start () {

		moveEixo = 0;
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (moveEixo * Time.deltaTime, 0,0);
	}

	public void Esq()
	{
		moveEixo = -1;
	}

	public void Dir()
	{
		moveEixo = 1;
	}

	public void Parado()
	{
		moveEixo = 0;
	}

	void OnTriggerEnter2D(Collider2D outro)
	{
		if(outro.gameObject.CompareTag("t1"))
		{
			t1.enabled = true;
		}
		if(outro.gameObject.CompareTag("t2"))
		{
			t2.enabled = true;
		}
		if(outro.gameObject.CompareTag("t3"))
		{
			t3.enabled = true;
		}
		if(outro.gameObject.CompareTag("t4"))
		{
			t4.enabled = true;
		}
	}

	void OnTriggerExit2D(Collider2D outro)
	{
		if(outro.gameObject.CompareTag("t1"))
		{
			t1.enabled = false;
		}
		if(outro.gameObject.CompareTag("t2"))
		{
			t2.enabled = false;
		}
		if(outro.gameObject.CompareTag("t3"))
		{
			t3.enabled = false;
		}
		if(outro.gameObject.CompareTag("t4"))
		{
			t4.enabled = false;
		}
	}

}
