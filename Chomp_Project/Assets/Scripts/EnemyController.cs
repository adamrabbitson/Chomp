using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

	// navAgent is nav mesh agent component for the enemy
	private NavMeshAgent navAgent;
	// agentDestination is the destination that the enemy will travel to
	public GameObject agentDestination;

	//---------------------------------------------------------------
	// Start ()
	// Called when the game starts
	//
	// Param:
	//		
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Start () {
		navAgent = GetComponent<NavMeshAgent> ();
	}

	//---------------------------------------------------------------
	// Update ()
	// Called every frame
	//
	// Param:
	//		
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Update () {
		if (agentDestination != null) {
			navAgent.destination = agentDestination.transform.position;
		}
	}
}