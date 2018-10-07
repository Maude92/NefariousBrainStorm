using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouleRelax : MonoBehaviour {

	public GameObject BoutonA;
	public GameObject BoutonB;
	public GameObject BoutonX;
	public GameObject BoutonY;

	Animator animA;
	Animator animB;
	Animator animX;
	Animator animY;


	// Use this for initialization
	void Start () {
		animA = BoutonA.GetComponent<Animator> ();
		animB = BoutonB.GetComponent<Animator> ();
		animX = BoutonX.GetComponent<Animator> ();
		animY = BoutonY.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D (Collider col){

		if (col.gameObject.tag == "A") {
			animcar.SetBool ("Move", true);
		}

		if (Input.GetButtonDown ("360_AButton") || Input.GetKeyDown (KeyCode.Q)) {
			print ("Je pèse sur le bouton A");
		}
	}
}
