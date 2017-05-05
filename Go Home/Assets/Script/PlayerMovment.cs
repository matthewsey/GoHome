using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour {

	Rigidbody rigidbody;
	public float moveSpeed;
	public float maxSpeed= 10f;
	private Vector3 input;

	private Vector3 spawn;

	// Use this for initialization
	void Awake () {

		rigidbody = GetComponent <Rigidbody> ();

	}

	void Start () {

		spawn = transform.position;
	}

	void Update () {
		//keys to move & the speed of the player
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (rigidbody.velocity.magnitude < maxSpeed) {

			rigidbody.AddForce (input * moveSpeed);
		}
	}

	void OnCollisionEnter (Collision other)
	{
		//once the player hits the enemy, he will be spawned from the beging
		if (other.transform.tag == "Enemy") {

			transform.position = spawn;
		} else {
			//if the player hits the goal of the game it wil take him to the Win scene
			if (other.transform.tag == "GoalToWin") {

				SceneManager.LoadScene ("YouWin");
			}
		}
	}
}



