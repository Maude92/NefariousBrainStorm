using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraScript : MonoBehaviour {

	public GameObject aura;
	public GameObject playerNuage;
	public GameObject cadre;
	public bool canBreath;

	Animator animAura;
	Animator animcadre;
	ControlsPlayer controlsplayerscript;


	// Use this for initialization
	void Start () {
		animAura = aura.GetComponent<Animator> ();
		animcadre = cadre.GetComponent<Animator> ();
		controlsplayerscript = playerNuage.GetComponent<ControlsPlayer> ();
		canBreath = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			animAura.SetBool ("Aura", true);
			animcadre.SetBool ("Danger", true);
			canBreath = true;
			controlsplayerscript.maxSpeed = 0.5f;
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			//controlsplayerscript.maxSpeed = 3f;
			StartCoroutine (GoBackToNormalSpeed());
			canBreath = false;
			animAura.SetBool ("Aura", false);
			animcadre.SetBool ("Danger", false);
		}
	}

	IEnumerator GoBackToNormalSpeed (){
		controlsplayerscript.maxSpeed = 0.6f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 0.7f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 0.8f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 0.9f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 1f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 1.2f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 1.4f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 1.6f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 1.8f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 2f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 2.2f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 2.4f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 2.6f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 2.8f;
		yield return new WaitForSeconds (0.1f);
		controlsplayerscript.maxSpeed = 3f;
	}
}
