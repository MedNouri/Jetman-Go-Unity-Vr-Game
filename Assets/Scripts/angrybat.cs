using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angrybat : MonoBehaviour {
	private Vector3 wayPointPos;
	private GameObject wayPoint;
	private float speed = 6.0f;
	Animator animator;   
	// Use this for initialization
	void Start ()
	{

		animator = GetComponent<Animator> ();


	}
	
	void OnTriggerEnter(Collider col){

		if(col.gameObject.tag=="player"){
			Debug.Log ("Player is here");
			wayPoint = GameObject.Find("Player");
			animator.SetBool ("attack",true);
			wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
			transform.position  = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
			Playerscore.PlayerHealth -=5;

		}
	} 
}
