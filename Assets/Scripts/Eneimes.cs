using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eneimes : MonoBehaviour {
 
	//You may consider adding a rigid body to the zombie for accurate physics simulation
	private GameObject wayPoint;
	private Vector3 wayPointPos;
	public AudioSource  robotSound;
	public AudioSource gun;
	public static int  life =3;
	Animator animator;                
	//This will be the zombie's speed. Adjust as necessary.
	private float speed = 6.0f;
	void Start ()
	{

		animator = GetComponent<Animator> ();
 
	
	}

	void Update ()
	{

	}

	void OnTriggerEnter(Collider col){
 
	//	if(col.gameObject.tag == "Player") {
		Debug.Log ("Player is here");
		wayPoint = GameObject.Find("Player");
		animator.SetBool ("attack",true);
		wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
		transform.position  = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
		 

		Debug.Log ("End OFthe GAme");
		animator.SetBool ("fight",true);
		}
	//	} 

	void OnTriggerExit (Collider col){
		//if (col.gameObject.tag == "Player") {
			Playerscore.PlayerHealth -= 2;

		//}
	}



    	public void attackEneimes(){
		gun.Play ();
		life -= 1;
		animator.SetBool ("gothit",true);
		if (life == 0) {
			animator.SetBool ("dead",true);
			Destroy(gameObject, 0.9f);
		}

	
	    }



}
