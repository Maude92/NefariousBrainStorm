using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterHouse : MonoBehaviour {
	public GameObject Canvas;
	// Use this for initialization
	void Start () {
		Canvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D( Collider2D other){
		if (other.gameObject.tag == "Player") {
			Canvas.SetActive (true);
		}
	}
}
