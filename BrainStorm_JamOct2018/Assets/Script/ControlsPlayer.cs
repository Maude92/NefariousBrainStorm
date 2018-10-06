using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsPlayer : MonoBehaviour {

	Rigidbody2D rbPlayer;

	public float maxSpeed = 3f;
	public bool modePause;
	//public int nombrederespiration;
	public GameObject canvasPause;
	public GameObject aura;
	public GameObject triggerZone1;

//	LevelMenuScript levelmenuscript;
	AuraScript aurascript;
	Animator animaura;


	// Use this for initialization
	void Start () {
		rbPlayer = GetComponent<Rigidbody2D> ();

	//	levelmenuscript = canvasPause.GetComponent<LevelMenuScript> ();
		aurascript = triggerZone1.GetComponent<AuraScript> ();
		animaura = aura.GetComponent<Animator> ();

		modePause = false;
		//nombrederespiration = 0;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		UserInputs ();
	}

	void FixedUpdate (){
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		rbPlayer.velocity = new Vector2 (h * maxSpeed, v * maxSpeed);
	}

	void UserInputs() {

		// A button
		if (Input.GetButtonDown ("360_AButton") || Input.GetKeyDown (KeyCode.Q)) {
			print ("Je pèse sur le bouton A");
		}

		// B button
		if (Input.GetButtonDown ("360_BButton") || Input.GetKeyDown (KeyCode.W)) {
			print ("Je pèse sur le bouton B");
		}

		// X button
		if (Input.GetButtonDown ("360_XButton") || Input.GetKeyDown (KeyCode.E)) {
			print ("Je pèse sur le bouton X");
		}

		// Y button
		if (Input.GetButtonDown ("360_YButton") || Input.GetKeyDown (KeyCode.R)) {
			print ("Je pèse sur le bouton Y");
		}

		// Back button
		if (Input.GetButtonDown ("360_BackButton")) {
			print ("Je pèse sur le bouton Back");
		}

		// Start button
		if (Input.GetButtonDown ("360_StartButton") || Input.GetKeyDown (KeyCode.Escape)) {
			print ("Je pèse sur Start");
			modePause = !modePause;

			if (modePause == true) {
				//controlsplayerscript.enabled = false;
				// désactiver UI inutile
				canvasPause.SetActive (true);
				Time.timeScale = 0;
			} else if (modePause == false) {
				Time.timeScale = 1;
				canvasPause.SetActive (false);
				// réactiver canvas utile
				//controlsplayerscript.enabled = true;
			}
		}


		// Triggers
		if ((Input.GetAxis ("360_TriggerL") > 0.001 && Input.GetAxis ("360_TriggerR") > 0.001)) {
			print ("Je pèse sur les Triggers ");
			if (aurascript.canBreath == true) {
				print ("Je suis censé inspirer");
				animaura.SetBool ("Inspire", true);
			} else {
				print ("T'as pas à respirer maintenant");
				animaura.SetBool ("Inspire", false);
			}
		} else if ((Input.GetAxis ("360_TriggerL") < 0.001 && Input.GetAxis ("360_TriggerR") < 0.001)) {
			if (aurascript.canBreath == true) {
				print ("Je suis censé expirer");
				animaura.SetBool ("Inspire", false);
			//	animaura.SetInteger ("Respiration", nombrederespiration);
			} else {
				print ("T'as pas à respirer maintenant");
				animaura.SetBool ("Inspire", false);
			}
		}
	}
}
