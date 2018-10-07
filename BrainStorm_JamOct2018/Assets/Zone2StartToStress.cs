using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone2StartToStress : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Attention") {
			print ("A car just passed! Omg!");
		}
	}
		
}
