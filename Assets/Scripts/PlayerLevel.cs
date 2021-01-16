using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour {
	public GameObject Play;
	public GameObject Resume;


	// Use this for initialization
	void Start () {
		

		try
		{ 
			string level = PlayerPrefs.GetString("level");
			if(int.Parse(level) ==2){
		
				Play.SetActive (false);
				Resume.SetActive (true);
				PlayerPrefs.SetString ("level", "1");
			}else if(int.Parse(level) ==1){


				Play.SetActive (true);
				Resume.SetActive (false);

			}
 
		}

			catch   
			{  
			Play.SetActive (true);
			Resume.SetActive (false);
			} 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
