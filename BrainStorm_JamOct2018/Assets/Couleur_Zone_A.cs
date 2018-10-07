using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Couleur_Zone_A : MonoBehaviour {

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

	void OnTriggerEnter2D (Collider2D col){
		StartCoroutine (StartTheShow());
	}

	IEnumerator StartTheShow (){
		animA.SetBool ("AToD1", true);
		yield return new WaitForSeconds (0.1f);
		animA.SetBool ("AToD1", false);

		yield return new WaitForSeconds (0.5f);

		animB.SetBool ("BToD2", true);
		yield return new WaitForSeconds (0.1f);
		animB.SetBool ("BToD2", false);

		yield return new WaitForSeconds (0.4f);

		animX.SetBool ("XToD3", true);
		yield return new WaitForSeconds (0.1f);
		animX.SetBool ("XToD3", false);

		yield return new WaitForSeconds (0.3f);

		animY.SetBool ("YToD4", true);
		yield return new WaitForSeconds (0.1f);
		animY.SetBool ("YToD4", false);



//		yield return new WaitForSeconds (0.1f);
//		yield return new WaitForSeconds (0.1f);

	}

	//List of Behavior :
//	animA.SetBool ("AToD1", true);
//	animA.SetBool ("AToD2", true);
//	animA.SetBool ("AToD3", true);
//	animA.SetBool ("AToD4", true);
//
//	animB.SetBool ("BToD1", true);
//	animB.SetBool ("BToD2", true);
//	animB.SetBool ("BToD3", true);
//	animB.SetBool ("BToD4", true);
//
//	animX.SetBool ("XToD1", true);
//	animX.SetBool ("XToD2", true);
//	animX.SetBool ("XToD3", true);
//	animX.SetBool ("XToD4", true);
//
//	animY.SetBool ("YToD1", true);
//	animY.SetBool ("YToD2", true);
//	animY.SetBool ("YToD3", true);
//	animY.SetBool ("YtoD4", true);
}
