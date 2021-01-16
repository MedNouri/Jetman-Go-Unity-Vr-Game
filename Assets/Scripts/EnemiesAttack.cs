using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAttack : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(){
	}


	void attack()
	{
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit))
		{
			if(hit.collider.gameObject.tag == "Player")
			{
				Playerscore.PlayerHealth -= 5;
			}
		}
	}
}
