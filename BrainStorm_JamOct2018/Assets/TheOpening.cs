using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheOpening : MonoBehaviour {

	public GameObject nuageyellow1;
	public GameObject nuageyellow2;
	public GameObject nuagebleu1;
	public GameObject nuagebleu2;
	public GameObject nuagegreen1;
	public GameObject nuagegreen2;
	public GameObject nuagepink;
	public GameObject nuagered;

	public GameObject player;
	public GameObject fakeplayerintro;

	Animator animYellow1;
	Animator animYellow2;
	Animator animBlue1;
	Animator animBlue2;
	Animator animGreen1;
	Animator animGreen2;
	Animator animPink;
	Animator animRed;

	SpriteRenderer realPlayerSprite;
	Collider2D realPlayerCollider;

	ControlsPlayer controlsplayerscript;

	// Use this for initialization
	void Start () {
		animYellow1 = nuageyellow1.GetComponent<Animator> ();
		animYellow2 = nuageyellow2.GetComponent<Animator> ();
		animBlue1 = nuagebleu1.GetComponent<Animator> ();
		animBlue2 = nuagebleu2.GetComponent<Animator> ();
		animGreen1 = nuagegreen1.GetComponent<Animator> ();
		animGreen2 = nuagegreen2.GetComponent<Animator> ();
		animPink = nuagepink.GetComponent<Animator> ();
		animRed = nuagered.GetComponent<Animator> ();

		controlsplayerscript = player.GetComponent<ControlsPlayer> ();

		StartCoroutine (StartOfTheGame ());

		realPlayerSprite = player.GetComponent<SpriteRenderer> ();
		realPlayerCollider = player.GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator StartOfTheGame(){
		controlsplayerscript.enabled = false;
		yield return new WaitForSeconds (5f);
		realPlayerSprite.enabled = true;
		realPlayerCollider.enabled = true;
		fakeplayerintro.SetActive (false);
		controlsplayerscript.enabled = true;
		animYellow1.SetBool ("Run", true);
		animYellow2.SetBool ("Run", true);
		animBlue1.SetBool ("Run", true);
		animBlue2.SetBool ("Run", true);
		animGreen1.SetBool ("Run", true);
		animGreen2.SetBool ("Run", true);
		animPink.SetBool ("Run", true);
		animRed.SetBool ("Run", true);
	}
}
