using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCarScript : MonoBehaviour {

	public GameObject car;

	Animator animcar;

	// Use this for initialization
	void Start () {
		animcar = car.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			animcar.SetBool ("Move", true);
		}
	}
}
