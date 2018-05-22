using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour {

	public GameObject Trigger_001_Start_001;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			
		}
	}
}
