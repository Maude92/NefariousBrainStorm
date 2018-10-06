using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float xMargin = 1f;
	public float yMargin = 1f;
	public float xySmooth = 3;
	public Vector2 maxXY;
	public Vector2 minXY;

	Transform playerTransform;

	//public Transform playerTransform;

	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	void LateUpdate(){
		trackPlayer ();
	}

	bool CheckXMargin(){
		return Mathf.Abs (transform.position.x - playerTransform.position.x) > xMargin;
	}

	bool CheckYMargin(){
		return Mathf.Abs (transform.position.y - playerTransform.position.y) > yMargin;
	}

	void trackPlayer(){
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		if (CheckXMargin ()) 
			targetX = Mathf.Lerp (transform.position.x, playerTransform.position.x, xySmooth * Time.deltaTime);
		

		targetX = Mathf.Clamp (targetX, minXY.x, maxXY.x);

		if (CheckYMargin ()) 
			targetY = Mathf.Lerp (transform.position.y, playerTransform.position.y, xySmooth * Time.deltaTime);
		
		targetY = Mathf.Clamp (targetY, minXY.y, maxXY.y);


		transform.position = new Vector3 (targetX, targetY, transform.position.z);
	}
}
