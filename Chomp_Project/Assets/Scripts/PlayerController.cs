using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// movementSpeed is the speed the player moves
	public float movementSpeed = 10;
	// turningSpeed is the speed the player strafes
	public float strafingSpeed = 10;
	// jumpSpeed is the speed the player jumps
	public float jumpSpeed = 1000.0f;
	// canJump is to check if the player has jumped too fast
	private float canJump = 0.0f;

	//---------------------------------------------------------------
	// Update ()
	// Called every frame
	//
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal") * strafingSpeed * Time.deltaTime;
		transform.Translate (horizontal, 0, 0);

		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate (0, 0, vertical);

		if (Input.GetAxis("Jump") > 0 && Time.time > canJump) {
			Jump ();
		}

		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			Crouch ();
		}

		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			UnCrouch ();
		}
	}

	//---------------------------------------------------------------
	// Jump ()
	// Called in Update - when player jumps
	//
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Jump () {
		GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpSpeed);
		canJump = Time.time + 1.3f;
	}

	//---------------------------------------------------------------
	// Crouch ()
	// Called in Update - when player crouches
	//
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Crouch () {
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 0.5f, transform.localScale.z);
	}

	//---------------------------------------------------------------
	// UnCrouch ()
	// Called in Update - when player uncrouches
	//
	// Return:
	//		Void
	//---------------------------------------------------------------
	void UnCrouch () {
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2.0f, transform.localScale.z);
	}
}
