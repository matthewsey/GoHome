using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// This will return the player to the main scene
	public void NewGame () {

		SceneManager.LoadScene ("Cube");

	}

}
