using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRaycats : MonoBehaviour {
	private RaycastHit hit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void FixedUpdate()
	{
		Vector3 fwd = transform.TransformDirection(Vector3.forward);

	//	if (Physics.Raycast(transform.position, fwd, 10))
	//		print("There is something in front of the object!");
	}
}


//Physics.Raycast( Camera.main.ScreenPointToRay( Input.mousePosition ), out hit, 1000f );

// Then you could find your GO with a specific tag by doing something like:
//if(hit.gameObject.tag == "Player") {
	// Do stuff.