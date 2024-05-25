using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class heroimove : MonoBehaviour {

	public bool face = true;
	public Transform heroiT;
	public float vel = 2.5f;
	public float vel2 = 10.0f;
	public float force = 6.5f;
	public Rigidbody2D heroiRB;

	public bool liberapulo = false;
	public Transform check;
	public LayerMask VerificaChao;
	public float raio = 0.2f;

	public Animator anim;
	public bool vivo = true;
	public int moedaItem = 0;
	public Text txtmoeda;
	public AudioClip coin;

	public GameObject MostrarTela;


	void Start () {

		heroiT = GetComponent<Transform> ();
		heroiRB = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

		MostrarTela.SetActive (false);
	}


	void Update () {


		if (Input.GetKey (KeyCode.RightArrow) && !face)
		{
			Flip ();
		}

		else if (Input.GetKey (KeyCode.LeftArrow) && face)
		{
			Flip ();
		}


		//VERIFICAR O CHAO

		liberapulo = Physics2D.OverlapCircle (check.position, raio, VerificaChao);
		//CORRER


		if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Q))
		{

			transform.Translate(new Vector2 (vel2 * Time.deltaTime,0));
			anim.SetBool ("Parado", false);
			anim.SetBool ("Andar", false);
			anim.SetBool ("Correr", true);
		}
		else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Q))
		{

			transform.Translate(new Vector2 (-vel2 * Time.deltaTime,0));
			anim.SetBool ("Parado", false);
			anim.SetBool ("Andar", false);
			anim.SetBool ("Correr", true);
		}

		//ANDAR
		else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.Q))
		{

			transform.Translate(new Vector2 (vel * Time.deltaTime,0));
			anim.SetBool ("Parado", false);
			anim.SetBool ("Andar", true);
			anim.SetBool ("Correr", false);
		}
		else if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.Q))
		{

			transform.Translate(new Vector2 (-vel * Time.deltaTime,0));
			anim.SetBool ("Parado", false);
			anim.SetBool ("Andar", true);
			anim.SetBool ("Correr", false);
		}

		else if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
		{
			
			anim.SetBool ("Parado", true);
			anim.SetBool ("Andar", false);
			anim.SetBool ("Correr", false);
		}

		if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
		{

			transform.Translate(new Vector2 (0,0));
			anim.SetBool ("Parado", true);

		}



		//PULO
		if(Input.GetKeyDown(KeyCode.Space) && liberapulo == true && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Q))
		{

			heroiRB.AddForce(new Vector2(0 , force), ForceMode2D.Impulse);
			anim.SetBool ("Pulo", true);
			anim.SetBool ("Correr", false);
		}
		else if(Input.GetKeyDown(KeyCode.Space) && liberapulo == true && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Q))
		{

			heroiRB.AddForce(new Vector2(0 , force), ForceMode2D.Impulse);
			anim.SetBool ("Pulo", true);
			anim.SetBool ("Correr", false);
		}
		else if(Input.GetKeyDown(KeyCode.Space) && liberapulo == true && Input.GetKey(KeyCode.RightArrow))
		{

			heroiRB.AddForce(new Vector2(0 , force), ForceMode2D.Impulse);
			anim.SetBool ("Pulo", true);
			anim.SetBool ("Andar", false);
		}

		else if(Input.GetKeyDown(KeyCode.Space) && liberapulo == true && Input.GetKey(KeyCode.LeftArrow))
		{

			heroiRB.AddForce(new Vector2(0 , force), ForceMode2D.Impulse);
			anim.SetBool ("Pulo", true);
			anim.SetBool ("Andar", false);
		}

		else if(Input.GetKeyDown(KeyCode.Space) && liberapulo == true)
		{

			heroiRB.AddForce(new Vector2(0 , force), ForceMode2D.Impulse);
			anim.SetBool ("Pulo", true);
			anim.SetBool ("Parado", false);
		}


	}

	void Flip()
	{
		face = !face;

		Vector3 escala = heroiT.localScale;
		escala.x *= -1;
		heroiT.localScale = escala;
	}

	void OnCollisionEnter2D(Collision2D outro)
	{
		if(outro.gameObject.CompareTag("chao"))
		{
			
			anim.SetBool ("Parado", true);
			anim.SetBool ("Pulo", false);

		}
		if(outro.gameObject.CompareTag("madeira"))
		{
			anim.SetBool ("Parado", true);
			anim.SetBool ("Pulo", false);

		}

		if(outro.gameObject.CompareTag("chaosala"))
		{
			anim.SetBool ("Parado", true);
			anim.SetBool ("Pulo", false);

		}
	}

	void OnTriggerEnter2D(Collider2D outro)
	{
		if(outro.gameObject.CompareTag("moeda"))
		{
			moedaItem++;
			txtmoeda.text = moedaItem.ToString ();
			gerenciador.inst.PlayAudio(coin);
			Destroy (outro.gameObject);
		}

		if(outro.gameObject.CompareTag("fim"))
		{
			
			if (moedaItem == 0 ) {
				MostrarTela.SetActive (true);

			}

			if (moedaItem == 1 ) {
				SceneManager.LoadScene ("MenuGanhou");

			}
		}

		if(outro.gameObject.CompareTag("fim1"))
		{
			
				SceneManager.LoadScene ("MenuGanhou 1");


		}

	}


	void OnTriggerExit2D(Collider2D ele)
	{
		if(ele.gameObject.CompareTag("fim"))
		{
			MostrarTela.SetActive (false);
		}
	}
				

}
