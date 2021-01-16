using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {
	public static bool soundon =true;
	public GameObject  camera ;
	public GameObject OptionMenu;
	public GameObject AboutMenu;
	public GameObject oNObject;
	public GameObject oFFObject;
	public GameObject pauseMenu;

	public GameObject START;
	public GameObject RESUME;
	private bool loadScene = false;

	[SerializeField]
	private int scene;




	public void GoToScene(int Number){
 


		StartCoroutine(LoadNewScene(Number));
	 
	}

	void Awake(){
	
		try{
			int lastlevel= PlayerPrefs.GetInt("lastScene");
			if(lastlevel==2){
			START.SetActive (false);
			RESUME.SetActive (true);
			}


		}catch{
			START.SetActive (true);
			RESUME.SetActive (false);

		}
	
	}




	public void GoToSceneOptions(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		Debug.Log ("Show Options");
		if (OptionMenu.activeInHierarchy) {
			OptionMenu.SetActive (false);
		} else {
		
			OptionMenu.SetActive (true);

			if (soundon == true) {
				oFFObject.SetActive (false);
				oNObject.SetActive (true);
		
			} 
			else if(soundon==false) {	
				oFFObject.SetActive (true);
				oNObject.SetActive (false);

			}
			 iTween.RotateTo(camera,iTween.Hash
				("y",276,"time",3,"delay",0,"onupdate","myUpdateFunction","looptype",
					iTween.LoopType.none));
			//camera.transform.Rotate(276f * Time.deltaTime, Space.World);
		}
			
	}


	public void GoToSceneAbout(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		Debug.Log ("About Menu");
		if (AboutMenu.activeInHierarchy) {
			AboutMenu.SetActive (false);
		} else {
			AboutMenu.SetActive (true);
			iTween.RotateTo(camera,iTween.Hash("y",-276,"time",3,"delay",0,"onupdate","myUpdateFunction","looptype",iTween.LoopType.none));
		
			//camera.transform.Rotate(-276f * Time.deltaTime, Space.World);
		}
	}


	public void SoundOff(){
		//Adding clicking Sound
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();

		Debug.Log ("My methode Sound is here ");
		if (soundon==false) {
			soundon = true;
			oFFObject.SetActive (false);
			oNObject.SetActive (true);
			audio.Play();
		} 
		else if(soundon==true){
			soundon = false;
			oFFObject.SetActive (true);
			oNObject.SetActive (false);
		
		}

	}



	public void pauseGame () {
		if (pauseMenu.activeInHierarchy) {
			pauseMenu.SetActive (false);

		} else {
			pauseMenu.SetActive (true);
			 

		}
		iTween.Pause ();
		Gamepause ();
	}




	public void resumeGame () {
		if (pauseMenu.activeInHierarchy) {
			pauseMenu.SetActive (false);

		} else {
			pauseMenu.SetActive (true);
			 
			//camera.transform.Rotate(-276f * Time.deltaTime, Space.World);
		}

		iTween.Resume ();
		Gamepresume ();
	}




	 
	IEnumerator LoadNewScene(int scene ) {
 
		yield return new WaitForSeconds(0);
		AsyncOperation async = Application.LoadLevelAsync(scene);
 
		while (!async.isDone) {
			yield return null;
		}

	}

	void Gamepause (){
		Time.timeScale = 0;
		Menu.soundon = false;
	}
	void Gamepresume (){
		Time.timeScale=1;
		Menu.soundon = true;
	}



}
