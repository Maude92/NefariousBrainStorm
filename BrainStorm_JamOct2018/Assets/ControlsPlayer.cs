using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsPlayer : MonoBehaviour {

	Rigidbody2D rbPlayer;

	public float maxSpeed = 3f;

	// Use this for initialization
	void Start () {
		rbPlayer = GetComponent<Rigidbody2D> ();
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
		if (Input.GetButtonDown ("360_AButton")){
			print ("Je pèse sur le bouton A");
		}

	// B button
		if (Input.GetButtonDown ("360_BButton")){
			print ("Je pèse sur le bouton B");
		}

	// X button
		if (Input.GetButtonDown ("360_XButton")){
			print ("Je pèse sur le bouton X");
		}

	// Y button
		if (Input.GetButtonDown ("360_YButton")){
			print ("Je pèse sur le bouton Y");
		}

	// Back button
		if (Input.GetButtonDown("360_BackButton")){
			print ("Je pèse sur le bouton Back");
		}

	// Start button
		if (Input.GetButtonDown ("360_StartButton")){
			print ("Je pèse sur Start");
		}

	// Trigger Left
		if (Input.GetAxis("360_TriggerL") > 0.001) {
			print ("Je pèse sur le Trigger Gauche (L) ");
		}

	// Trigger Right
		if (Input.GetAxis ("360_TriggerR") > 0.001){
			print ("Je pèse sur le Trigger Droit (R)");
		}

	}
}
