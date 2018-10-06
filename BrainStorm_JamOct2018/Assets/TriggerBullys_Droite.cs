using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBullys_Droite : MonoBehaviour {

	public GameObject Bully1;
	public GameObject Bully2;

	Animator animBully1;
	Animator animBully2;

	// Use this for initialization
	void Start () {
		animBully1 = Bully1.GetComponent<Animator> ();
		animBully2 = Bully2.GetComponent<Animator> ();
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			animBully1.SetBool ("MoveDroite", true);
			animBully2.SetBool ("MoveDroite", true);
		}
	}
}
