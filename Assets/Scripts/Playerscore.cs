using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class Playerscore : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public static int PlayerHealth;
	public static float count;
	public float myTime;
	public Text timertext;
	public GameObject objectYouLose; 

	void Awake ()
	{		myTime=100;
		PlayerHealth = 10;
		count = 0;
	    try
		{
			TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
			string Score = PlayerPrefs.GetString ("Score");
			if (Score != null) {
				t.text=Score;
			} else
				t.text= "No Recorder yet";
			
		}
 
	   catch   
	{  
			// Error: Use No Score Found ERROR  
	} 
	
	}


	void start(){


	}


	void Update(){

		if (PlayerHealth<=0){
			StartCoroutine(ActivationRoutine(objectYouLose));
			RestartScene ();
			PlayerPrefs.SetInt("lastScene",0);

			iTween.Pause ();

		 
		

		}

		SetCountText ();
	}
 

 
 
	void SetCountText ()
	{
	//	countText.text = "Count: " + count.ToString ();
		string Score =PlayerPrefs.GetString("Score");
		//int BestScore = int.Parse(Score);
		int memeValue;
		// attempt to parse the value using the TryParse functionality of the integer type
		int.TryParse(Score , out memeValue);
		if (count >=memeValue)
		{
			PlayerPrefs.SetString ("Score", count.ToString ());
			//SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		}
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
		SceneManager.LoadScene( SceneManager.GetActiveScene().name );
	}

	private IEnumerator RestartScene( )
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds (5);

		SceneManager.LoadScene( SceneManager.GetActiveScene().name );

 
	}

}