using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	// player is the player that the camera follows
	public GameObject player;
	// rotateSpeed is the speed that the camera will rotate at
	public float rotateSpeed = 5;
	// offset is the difference between the player and camera location
	Vector3 offset;

	//---------------------------------------------------------------
	// Start ()
	// Called when game is started
	//
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Start() {
		offset = player.transform.position - transform.position;
	}

	//---------------------------------------------------------------
	// LateUpdate ()
	// Called every frame after Update is finished
	//
	// Return:
	//		Void
	//---------------------------------------------------------------
	void LateUpdate() {
		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
		player.transform.Rotate(0, horizontal, 0);

		float desiredAngle = player.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
		transform.position = player.transform.position - (rotation * offset);

		transform.LookAt(player.transform);
	}
}