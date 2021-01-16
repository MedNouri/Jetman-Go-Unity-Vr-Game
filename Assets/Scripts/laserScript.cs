using UnityEngine;
using System.Collections;

public class laserScript : MonoBehaviour {
	public Transform startPoint;
	public Transform endPoint;
	LineRenderer laserLine;
	AudioSource audio;
	public	GameObject laserpointer,laser ;
 bool active =true;
	// Use this for initialization
	void Start () {
		laserLine = GetComponentInChildren<LineRenderer> ();
		laserLine.SetWidth (.2f, .2f);
		audio = GetComponent<AudioSource>();
		 
	}
	
	// Update is called once per frame
	void Update () {
		
			
			laserLine.SetPosition (0, startPoint.position);
			laserLine.SetPosition (1, endPoint.position);

		  if(active==false){
			audio.Pause ();

		}
			
			
		 
		

	}

	void OnTriggerEnter(Collider col){
		if (active == true) {
		//	if(col.gameObject.name== "VRplayer") {
				Playerscore.PlayerHealth = 0;
				Debug.Log ("Player should be dead");
			   
		//	}
		}else if(active==false){
			Debug.Log ("Player should pass");

		}
	
	}

 
	public  void buttonControll2(){

		 
		laser.SetActive (false);
		laserpointer.SetActive (false);

	 active = false;

	}

 

}