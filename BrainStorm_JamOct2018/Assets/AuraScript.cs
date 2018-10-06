using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraScript : MonoBehaviour {

	public GameObject aura;
	public GameObject playerNuage;
	public bool canBreath;

	Animator animAura;
	ControlsPlayer controlsplayerscript;

	// Use this for initialization
	void Start () {
		animAura = aura.GetComponent<Animator> ();
		controlsplayerscript = playerNuage.GetComponent<ControlsPlayer> ();
		canBreath = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			animAura.SetBool ("Aura", true);
			canBreath = true;
			controlsplayerscript.maxSpeed = 0.5f;
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			controlsplayerscript.maxSpeed = 3f;
			canBreath = false;
			animAura.SetBool ("Aura", false);
		}
	}
}
