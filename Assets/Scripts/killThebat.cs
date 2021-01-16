using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killThebat : MonoBehaviour {
	Rigidbody rigidoby;
	private AudioSource _audio ;
	int life=3;
	// Use this for initialization

	private Vector3 wayPointPos;
	private GameObject wayPoint;
	private float speed = 6.0f;
	Animator animator;   
	bool cankill=true;
	// Use this for initialization
	void Start ()
	{

		animator = GetComponent<Animator> ();

 
		_audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	public void killme () {
		_audio.Play ();
		life -= 1;
		if(life==0){
			cankill = false;
			rigidoby= GetComponent<Rigidbody>();
			rigidoby.useGravity = true;
			Destroy(gameObject, 4f);
		}
	
	}

	void OnTriggerEnter(Collider col){

	 
			 
			wayPoint = GameObject.Find("Player");
			animator.SetBool ("attack",true);
			wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
			transform.position  = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
			 

	 
	} 



	void OnTriggerExit (Collider col){
		if (cankill == true) {
			Playerscore.PlayerHealth -= 3;
		}

	}

}
