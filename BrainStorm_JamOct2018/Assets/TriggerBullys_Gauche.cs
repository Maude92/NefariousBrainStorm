﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBullys_Gauche : MonoBehaviour {

	public GameObject Bully1;
	public GameObject Bully2;

	Animator animBully1;
	Animator animBully2;

	// Use this for initialization
	void Start () {
		animBully1 = Bully1.GetComponent<Animator> ();
		animBully2 = Bully2.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			animBully1.SetBool ("MoveGauche", true);
			animBully2.SetBool ("MoveGauche", true);
		}
	}
}
