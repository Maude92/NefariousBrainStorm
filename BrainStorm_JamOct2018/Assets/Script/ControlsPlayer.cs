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

	public bool inspire;
	//public bool jerespire;
	public float timefade = 1f;
	public GameObject cadre;

	public float minScale = 0.65f;
	public float maxScale = 1.5f;

	public int letsbreath;
	public bool letsbreathbool;


//	LevelMenuScript levelmenuscript;
	AuraScript aurascript;
	Animator animaura;

	private AudioManager audioManager;


	// Use this for initialization
	void Start () {
		rbPlayer = GetComponent<Rigidbody2D> ();

	//	levelmenuscript = canvasPause.GetComponent<LevelMenuScript> ();
		aurascript = triggerZone1.GetComponent<AuraScript> ();
		animaura = aura.GetComponent<Animator> ();

		modePause = false;
		//nombrederespiration = 0;
		Time.timeScale = 1;

		inspire = false;
		//jerespire = false;
		letsbreath = 0;
		letsbreathbool = false;

		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}
	}
	 
	// Update is called once per frame
	void Update () {
		UserInputs ();

		if (aurascript.canBreath == true && inspire == true) {
		// change le scale pour inspirer
			if (cadre.transform.localScale.x < maxScale) {
				cadre.transform.localScale += new Vector3 (Time.deltaTime / timefade, Time.deltaTime / timefade, 0);
			} //else if (cadre.transform.localScale.x >= maxScale) {
			//	cadre.transform.localScale.x = maxScale;
			//	cadre.transform.localScale.y = maxScale;
				//cadre.transform.localScale.z = 1;
		//	}

		} else if (aurascript.canBreath == true && inspire == false){
			// change le scale pour expirer
			if (cadre.transform.localScale.x > minScale) {
				cadre.transform.localScale -= new Vector3 (Time.deltaTime / timefade, Time.deltaTime / timefade, 0);
			} //else if (cadre.transform.localScale.x <= minScale) {
				//cadre.transform.localScale.x = minScale;
				//cadre.transform.localScale.y = minScale;
			//	cadre.transform.localScale.z = 1;
			}

		if (letsbreathbool == true) {
			letsbreath++;
		} else if (letsbreathbool == false){
			letsbreath = 0;
		}
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
			audioManager.PlaySound ("SFX_BoutonA");
		}

		// B button
		if (Input.GetButtonDown ("360_BButton") || Input.GetKeyDown (KeyCode.W)) {
			print ("Je pèse sur le bouton B");
			audioManager.PlaySound ("SFX_BoutonB");
		}

		// X button
		if (Input.GetButtonDown ("360_XButton") || Input.GetKeyDown (KeyCode.E)) {
			print ("Je pèse sur le bouton X");
			audioManager.PlaySound ("SFX_BoutonX");
		}

		// Y button
		if (Input.GetButtonDown ("360_YButton") || Input.GetKeyDown (KeyCode.R)) {
			print ("Je pèse sur le bouton Y");
			audioManager.PlaySound ("SFX_BoutonY");
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
				inspire = true;
				StartCoroutine (BreathSoundWithTriggers ());
//				if (Input.GetAxis ("360_TriggerL") == 0.9 && inspire == true) {
//					audioManager.PlaySound ("SFX_Inspire");
//				}
				print ("Je suis censé inspirer");
				//jerespire = true;
				animaura.SetBool ("Inspire", true);
			} else {
				print ("T'as pas à respirer maintenant");
				//jerespire = false;
				inspire = false;
				animaura.SetBool ("Inspire", false);
			}
		} else if ((Input.GetAxis ("360_TriggerL") < 0.001 && Input.GetAxis ("360_TriggerR") < 0.001)) {
			if (aurascript.canBreath == true) {
				print ("Je suis censé expirer");
				inspire = false;
				StartCoroutine (BreathSoundWithTriggers ());
//				if (Input.GetAxis ("360_TriggerL") == 0.8 && inspire == false) {
//					audioManager.PlaySound ("SFX_Expire");
//				}
				//jerespire = true;
				animaura.SetBool ("Inspire", false);
			//	animaura.SetInteger ("Respiration", nombrederespiration);
			} else {
				print ("T'as pas à respirer maintenant");
			//	jerespire = false;
				inspire = false;
				animaura.SetBool ("Inspire", false);
			}
		}
	}

	IEnumerator BreathSoundWithTriggers(){
		letsbreathbool = true;
		if (inspire == true && letsbreath == 1) {
			audioManager.PlaySound ("SFX_Inspire");
			print ("Je devrais entendre inspirer");
		} else if (inspire == false && letsbreath == 1) {
			audioManager.PlaySound ("SFX_Expire");
			print ("Je devrais entendre expirer");
		}
		yield return new WaitForSeconds (0.2f);
		letsbreathbool = false;
	}
}
