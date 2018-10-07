using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSoundBreath : MonoBehaviour {

	private AudioManager audioManager;

	Collider2D thiscollider;


	// Use this for initialization
	void Start () {
		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}

		thiscollider = GetComponent<Collider2D> ();
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			audioManager.PlaySound ("SFX_RespirationWin");
			//StartCoroutine (ExitThatCollider ());
			//thiscollider.enabled = false;
		}
	}

//	IEnumerator ExitThatCollider(){
//		yield return new WaitForSeconds (5f);
//		thiscollider.enabled = false;
//	}
}
