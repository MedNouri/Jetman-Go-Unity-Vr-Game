using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AduioController : MonoBehaviour {
	private AudioSource _audio;
	// Use this for initialization
	void Start () {
		_audio = GetComponent<AudioSource>();


	}
	
 
	void Update () {
	       
		if (_audio != null) {
			if (Menu.soundon == false) {
				_audio.Stop ();
			}  
		}
		 
	}
}
