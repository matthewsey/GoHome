using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// This will return the player to the main scene
	//menu scene will take you to the game 
	public void NewGame () {

		SceneManager.LoadScene ("Cube");

	}

}
