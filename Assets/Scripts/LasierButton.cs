﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LasierButton : MonoBehaviour {
	public   Animator anim;

	// Use this for initialization
	void Start () {
 
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public  void buttonControll(){
		 
		anim.SetBool ("used",true);
 

	}








 
}
