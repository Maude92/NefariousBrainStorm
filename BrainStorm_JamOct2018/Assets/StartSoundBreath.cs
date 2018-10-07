using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSoundBreath : MonoBehaviour {

	private AudioManager audioManager;

	Collider2D thiscollider;


	// Use this for initialization
	void Start () {
		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}

		thiscollider = GetComponent<Collider2D> ();
	}
	
	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			audioManager.PlaySound ("SFX_RespirationFail");
		//	StartCoroutine (ExitThatCollider ());
			//thiscollider.enabled = false;
		}
	}

//	IEnumerator ExitThatCollider(){
//		yield return new WaitForSeconds (0.2f);
//		thiscollider.enabled = false;
//	}
}
