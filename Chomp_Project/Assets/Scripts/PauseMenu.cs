using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// menu is a reference to the PauseMenu object
     public GameObject menu;
	 // isShowing is the boolean that enables and disables the menu
     private bool isShowing;
 
	//---------------------------------------------------------------
	// Start ()
	// Called when game is started
	//
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	void Start () {
		Cursor.visible = false;
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
         if (Input.GetKeyDown("escape")) {
			 Cursor.visible = !isShowing;
             isShowing = !isShowing;
             menu.SetActive(isShowing);
         }
     }

	//---------------------------------------------------------------
	// QuitGame ()
	// Called when 'Quit' button is pressed
	//
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	public void QuitGame () {
		Application.Quit();
		Debug.Log("You have quit the game!");
	}

	//---------------------------------------------------------------
	// MainMenu ()
	// Called when 'Main Menu' button is pressed
	//
	// 
	// Return:
	//		Void
	//---------------------------------------------------------------
	public void MainMenu () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}
