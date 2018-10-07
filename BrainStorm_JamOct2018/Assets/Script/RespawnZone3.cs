using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnZone3 : MonoBehaviour {

	public GameObject bully1;
	public GameObject bully2;
	public GameObject player;

	public GameObject respawnpointbully1;
	public GameObject respawnpointbully2;
	public GameObject respawnpointplayer;

	public GameObject triggergauche;
	public GameObject triggerdroite;

	public GameObject fondNoirRespawn;

	Animator animFondNoirRespawn;
	Animator animbully1;
	Animator animbully2;

	Collider2D collidertriggerbully1;
	Collider2D collidertriggerbully2;

	// Use this for initialization
	void Start () {
		animFondNoirRespawn = fondNoirRespawn.GetComponent<Animator> ();
		animbully1 = bully1.GetComponent<Animator> ();
		animbully2 = bully2.GetComponent<Animator> ();

		collidertriggerbully1 = triggergauche.GetComponent<Collider2D> ();
		collidertriggerbully2 = triggerdroite.GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			StartCoroutine (RespawnPlayerAndBullies());
		}
	}

	IEnumerator RespawnPlayerAndBullies(){
		animFondNoirRespawn.SetBool ("Respawn", true);
		yield return new WaitForSeconds (2f);
		animbully2.SetBool ("Respawn", true);
		animbully1.SetBool ("Respawn", true);
		collidertriggerbully1.enabled = true;
		collidertriggerbully2.enabled = true;
		bully1.transform.position = respawnpointbully1.transform.position;
		bully2.transform.position = respawnpointbully2.transform.position;
		player.transform.position = respawnpointplayer.transform.position;
	}
}
