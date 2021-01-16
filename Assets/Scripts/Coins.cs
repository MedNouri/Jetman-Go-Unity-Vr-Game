using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Coins : MonoBehaviour {
	public float speed;
	Animator anim;
	public Text countText;
	public int 	count;
	private AudioSource _audio ;



	void Start () {
		count=0;
		 anim = GetComponent<Animator> ();
		_audio = GetComponent<AudioSource>();
	}
	
 
		void Update () {
		transform.Rotate (Vector3.up *speed* Time.deltaTime, Space.Self);

		}



 


	public void getcoin(){
		anim.SetBool ("coin",false);
		Playerscore.count += 10;
		 
		 //countText.text =  count.ToString ();
		_audio.Play ();
		 Destroy(gameObject, 0.2f);
	
	
	} 


	public void getBiggercoin(){
		Playerscore.count += 100;
		Debug.Log (Playerscore.count);
		//countText.text =  count.ToString ();
		// anim.SetBool ("goteaten",true);
		Destroy(gameObject, 0.5f);


	} 





}