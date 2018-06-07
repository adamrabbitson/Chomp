using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTeleport : MonoBehaviour {

	//---------------------------------------------------------------
	// OnTriggerEnter ()
	// Called when the trigger is entered
	//
	// Param:
	//		Collider other - A collider that enters the trigger, but is not the trigger
	// Return:
	//		Void
	//---------------------------------------------------------------
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			SceneManager.LoadScene("Main");
		}
	}
}
