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

	public bool AisHere = false;
	public bool isBHere = false;
	public bool isXHere = false;
	public bool isYHere = false;


	// Use this for initialization
	void Start () {
		animA = BoutonA.GetComponent<Animator> ();
		animB = BoutonB.GetComponent<Animator> ();
		animX = BoutonX.GetComponent<Animator> ();
		animY = BoutonY.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
	
//		if (isAHere == true && (Input.GetKeyDown (KeyCode.Q) || Input.GetButtonDown ("360_AButton"))) {
//			animA.SetBool ("DestroyGreen", true);
//		}

//		if (animA.GetBool ("OnScreen") == true && (Input.GetKeyDown (KeyCode.Q) || Input.GetButtonDown ("360_AButton"))) {
//			animA.SetBool ("DestryGreen", true);
//		}
	}

	void OnTriggerEnter2D (Collider2D col){

		if (col.gameObject.tag == "A") {
			AisHere = true;
				
		}



//		if (col.gameObject.tag == "B") {
//			isBHere = true;
//
//			if (Input.GetButtonDown ("360_BButton") || Input.GetKeyDown (KeyCode.W)) {
//				animB.SetBool ("DestroyRed", true);
//			}	
//		}
//
//		if (col.gameObject.tag == "X") {
//			isXHere = true;
//
//			if (Input.GetButtonDown ("360_XButton") || Input.GetKeyDown (KeyCode.E)) {
//				animX.SetBool ("DestroyBlue", true);
//			}	
//		}
//
//		if (col.gameObject.tag == "Y") {
//			isYHere = true;
//
//			if (Input.GetButtonDown ("360_YButton") || Input.GetKeyDown (KeyCode.R)) {
//				animY.SetBool ("DestroyYellow", true);
//			}	
//		}
			
	}

	void OnTriggerStay2D (Collider2D col){
		if (AisHere == true && (Input.GetKeyDown (KeyCode.Q) || Input.GetButtonDown ("360_AButton"))) {
			animA.SetBool ("DestroyGreen", true);
		}
	}

//	void OnTriggerExit2D (Collider2D col){
//		if (col.gameObject.tag == "A") {
//			animA.SetBool ("ReturnHome", true);
//		}
//
//		if (col.gameObject.tag == "B") {
//			animB.SetBool ("ReturnHome", true);
//		}
//
//		if (col.gameObject.tag == "X") {
//			animX.SetBool ("ReturnHome", true);
//		}
//
//		if (col.gameObject.tag == "Y") {
//			animY.SetBool ("ReturnHome", true);
//		}
//	}

	//animcar.SetBool ("Move", true);

}
