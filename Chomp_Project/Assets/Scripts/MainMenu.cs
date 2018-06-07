using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	//---------------------------------------------------------------
	// PlayGame ()
	// Called when the 'Play Game' button is pressed
	// 
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	public void PlayGame () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	//---------------------------------------------------------------
	// QuitGame ()
	// Called when the 'Quit Game' button is pressed
	// 
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	public void QuitGame() {
		Application.Quit();
		Debug.Log("You have quit the game!");
	}
}
