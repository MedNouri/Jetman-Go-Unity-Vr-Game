using System.Collections;
using System.Collections.Generic;	
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Quaternion  rotation;
	public float speed;
	public GameObject LearnHwotoPlay;
	private AudioSource _audioMoving ;
	public bool level1;
	public bool level2;
	public GameObject objectGo;


	void Awake(){
		try
		{
			 
			int firstTime = PlayerPrefs.GetInt("firstTime");
			if (firstTime != 10) {
				// No Recorder yet  See HOW to Paly "
				LearnHwotoPlay.SetActive (true);
				Debug.Log ("First time !");
				iTween.Pause ();

			}  else{
				// No need For 
				GameObject.Destroy (LearnHwotoPlay);
				Debug.Log ("Not the First time Remove for the Game !");
				startlevel();
			}
		}
			 

		catch   
		{  
			Debug.Log ("ooopss !");
		} 

	
	}




	void Start(){
		
		StartCoroutine(ActivationRoutine(objectGo));
		// Soudn Of the Jet 
		_audioMoving=GetComponent<AudioSource>();
		if (level1 == true) {
			iTween.MoveTo (gameObject, iTween.Hash ("path", iTweenPath.GetPath ("playerpath"), "time", speed, "easetype", iTween.EaseType.easeInOutSine));
		} else if (level2 == true) {
			iTween.MoveTo (gameObject, iTween.Hash ("path", iTweenPath.GetPath ("level2"), "time", speed, "easetype", iTween.EaseType.easeInOutSine));

		
		}
	 

	 
	}




	public void endFirstTime(){
		PlayerPrefs.SetInt("firstTime", 10);
		GameObject.Destroy (LearnHwotoPlay);
		startlevel();
	}






	void playermove(){
	     iTween.Resume ();
		_audioMoving.Play ();

		 
	}

	void playerStop(){
	iTween.Pause ();
		_audioMoving.Stop ();


	}



	void Update () {
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			playerStop ();
		} else if(Input.GetKeyDown (KeyCode.UpArrow)){
			playermove ();
		
		}
	}



	void startlevel(){
		iTween.Resume();
	}


	private IEnumerator ActivationRoutine(GameObject signobject )
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds (1);

		//Turn My game object that is set to false(off) to True(on).
		signobject .SetActive (true);

		//Turn the Game Oject back off after 1 sec.
		yield return new WaitForSeconds (4);

		//Game object will turn off
		signobject.SetActive (false);

	}


}
