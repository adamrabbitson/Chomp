using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {

	// attackDamage is the amount of damage that the enemy will give to the player (20%)
	public float attackDamage = 0.2f;

	//---------------------------------------------------------------
	// OnCollisionEnter ()
	// Called when something collides with the object
	// 
	// Params:
	// 		Collision other - An other collider that hits the collision
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerHealth> ().TakeDamage (attackDamage);
		}
	}
}
