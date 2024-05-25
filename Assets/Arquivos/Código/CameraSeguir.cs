using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour {

	public Transform pt;
	public Transform ct;
	public bool bounds;
	public Vector3 minCamera;
	public Vector3 maxCamera;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		ct.position = Vector3.Lerp(
			ct.position,
			new Vector3 (pt.position.x, ct.position.y, ct.position.z),
			1f);

		if(bounds){
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCamera.x, maxCamera.x), Mathf.Clamp(transform.position.y, minCamera.y, maxCamera.y), Mathf.Clamp(transform.position.z, minCamera.z, maxCamera.z));
		}


	}
}
