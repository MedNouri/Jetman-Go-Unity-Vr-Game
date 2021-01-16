using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {
	public float amplitude;        
	public float speed;                  
	public float tempVal;
	public Vector3 tempPos;
	private AudioSource _audio;
	void Start () 
	{
		tempVal = transform.position.y;
		  _audio = GetComponent<AudioSource>();
	}

	void Update () 
	{        
		if (_audio != null) {
			if (Menu.soundon == false) {
				_audio.Stop ();
			}
		
		}
		tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
		transform.position = tempPos;
	}
}
