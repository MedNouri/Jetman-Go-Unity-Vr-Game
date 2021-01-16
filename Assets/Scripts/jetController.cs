using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true; //activate the gyro on the phone
	}

		void Update()
		{

		Quaternion att = Input.gyro.attitude; //get the gyro data
		att = Quaternion.Euler(90f, 0f, 0f) * new Quaternion(att.x, att.y, -att.z, -att.w); //reorient the gyro data with the display
	   var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		 
			transform.Translate(0, 0, z);
		 transform.rotation = att;
		}




 

	}
 
