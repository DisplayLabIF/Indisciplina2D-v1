using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerenciador : MonoBehaviour {

	public AudioSource sons;
	public static gerenciador inst = null;

	void Awake()
	{
		if (inst == null) {
			inst = this;
		} 
		else if (inst != this) 
		{
			Destroy(gameObject);
		}

		print (this);
	}

	public void PlayAudio (AudioClip clipAudio)
	{
		sons.clip = clipAudio;
		sons.Play();
	}
}
