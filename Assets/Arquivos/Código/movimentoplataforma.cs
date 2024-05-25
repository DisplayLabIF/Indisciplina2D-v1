using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoplataforma : MonoBehaviour {

	private Vector3 posA;
	private Vector3 posB;
	private Vector3 proxima;

	[SerializeField]
	private float speed;

	[SerializeField]
	private Transform childTransform;

	[SerializeField]
	private Transform transformB;

	[SerializeField]


	// Use this for initialization
	void Start () {

		posB = childTransform.localPosition;
		posB = transformB.localPosition;
		proxima = posB;
	}
	
	// Update is called once per frame
	void Update () {

		move ();
	}

	private void move()
	{
		childTransform.localPosition = Vector3.MoveTowards (childTransform.localPosition, proxima, speed * Time.deltaTime);

		if (Vector3.Distance (childTransform.localPosition, proxima) <= 0.1) {

			destino ();
		}
	}

	private void destino()
	{
		proxima = proxima != posA ? posA : posB;
	}
}
