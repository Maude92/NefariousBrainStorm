using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicToNormal : MonoBehaviour {

	public GameObject musicnormal;
	public GameObject musicconfrontation;
	AudioSource audiosourcemusicnormal;
	AudioSource audiosourcemusicconfrontation;
	public float timefade = 5f;
	public bool fadeoutconfrontation;

	// Use this for initialization
	void Start () {
		audiosourcemusicnormal = musicnormal.GetComponent <AudioSource> ();
		audiosourcemusicconfrontation = musicconfrontation.GetComponent<AudioSource> ();
		fadeoutconfrontation = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (fadeoutconfrontation == true) {
			audiosourcemusicconfrontation.volume -= Time.deltaTime / timefade;
			audiosourcemusicnormal.volume += Time.deltaTime / timefade;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			//fadeinconfrontation = false;
			fadeoutconfrontation = true;
		}
	}
}
