using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCarScript : MonoBehaviour {

	public GameObject car;

	Animator animcar;

	private AudioManager audioManager;

	Collider2D thiscollider;

	// Use this for initialization
	void Start () {
		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}

		animcar = car.GetComponent<Animator> ();
		thiscollider = GetComponent<Collider2D> ();
	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			animcar.SetBool ("Move", true);
			audioManager.PlaySound ("SFX_VoitureRapide");
			thiscollider.enabled = false;
		}
	}
}
