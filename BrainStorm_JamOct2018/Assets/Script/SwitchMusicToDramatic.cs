using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicToDramatic : MonoBehaviour {

	public GameObject musicnormal;
	public GameObject musicconfrontation;
	AudioSource audiosourcemusicnormal;
	AudioSource audiosourcemusicconfrontation;
	public float timefade = 1f;
	public bool fadeinconfrontation;
	public bool fadeoutconfrontation;

	// Use this for initialization
	void Start () {
		audiosourcemusicnormal = musicnormal.GetComponent <AudioSource> ();
		audiosourcemusicconfrontation = musicconfrontation.GetComponent<AudioSource> ();
		fadeinconfrontation = false;
		fadeoutconfrontation = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (fadeinconfrontation == true) {
			audiosourcemusicconfrontation.volume += Time.deltaTime / timefade;
			audiosourcemusicnormal.volume -= Time.deltaTime / timefade;
		}	

//		if (fadeoutconfrontation == true) {
//			audiosourcemusicconfrontation.volume -= Time.deltaTime / timefade;
//			audiosourcemusicnormal.volume += Time.deltaTime / timefade;
//		}
	}


	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			fadeinconfrontation = true;
			//fadeoutnormal = true;
		}
	}


	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			fadeinconfrontation = false;
			//fadeoutconfrontation = true;
		}
		}

	
	}

