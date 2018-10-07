using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCarScript : MonoBehaviour {

	public GameObject car;

	Animator animcar;

	private AudioManager audioManager;

	Collider2D thiscollider;


	// Idem aura script : 
	public GameObject aura;
	public GameObject playerNuage;
	public GameObject cadre;
	public bool canBreath;
	Animator animAura;
	Animator animcadre;
	ControlsPlayer controlsplayerscript;
	//public GameObject InstructionRespiration;
	//Animator animTrigger;


	// Use this for initialization
	void Start () {
		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}

		animcar = car.GetComponent<Animator> ();
		thiscollider = GetComponent<Collider2D> ();


		// Idem aura script :
		animAura = aura.GetComponent<Animator> ();
		animcadre = cadre.GetComponent<Animator> ();
		controlsplayerscript = playerNuage.GetComponent<ControlsPlayer> ();
		canBreath = false;
		//animTrigger = InstructionRespiration.GetComponent<Animator> ();
	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			animcar.SetBool ("Move", true);
			audioManager.PlaySound ("SFX_VoitureRapide");
			StartCoroutine (ImScared ());
			thiscollider.enabled = false;
		}
	}

	IEnumerator ImScared(){
		yield return new WaitForSeconds (1.5f);
		print ("I'm scared now");
		audioManager.PlaySound ("SFX_RespirationFail");
		animAura.SetBool ("Aura", true);
		animcadre.SetBool ("Danger", true);
		canBreath = true;
		controlsplayerscript.maxSpeed = 0.5f;
		yield return new WaitForSeconds (11f);
		StartCoroutine (GoBackToNormalSpeed());
		//audioManager.PlaySound ("SFX_RespirationWin");
		canBreath = false;
		animAura.SetBool ("Aura", false);
		animcadre.SetBool ("Danger", false);
	}

	IEnumerator GoBackToNormalSpeed (){
		canBreath = false;
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
