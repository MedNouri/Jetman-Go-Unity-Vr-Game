using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mytimer : MonoBehaviour {
	public float myTime=100;
	public Text timertext;



	// Use this for initialization
	void Start () {
		timertext = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
 
		myTime -= Time.deltaTime;
		GetComponent<TextMesh>().text =myTime.ToString("f0");
		if (myTime == 0) {
		
			Playerscore.PlayerHealth = 0;
		}


	}
}
