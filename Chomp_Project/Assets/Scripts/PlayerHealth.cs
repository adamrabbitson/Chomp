using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	// health is the health float used to determine the health bar's value
	public float health = 1.0f;
	// healthBar is the slider used to display the amount of health the player currently has
	public Slider healthBar;

	//---------------------------------------------------------------
	// TakeDamage ()
	// Called when you take damage from enemy
	//
	// Params:
	//		float amount - the amount of damage that you will take that will affect the health bar
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	public void TakeDamage(float amount) {
		health -= amount;

		Debug.Log (health);
		Debug.Log (amount);
	}

	//---------------------------------------------------------------
	// Update ()
	// Called every frame
	//
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Update () {
		healthBar.value = health;

		Debug.Log (healthBar.value);

		if (health <= 0)
		{
			Destroy (this.gameObject);
		}
	}
}
