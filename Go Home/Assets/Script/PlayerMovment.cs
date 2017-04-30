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

		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (rigidbody.velocity.magnitude < maxSpeed) {

			rigidbody.AddForce (input * moveSpeed);
		}
	}

	void OnCollisionEnter (Collision other)
	{

		if (other.transform.tag == "Enemy") {

			transform.position = spawn;
		} else {

			if (other.transform.tag == "GoalToWin") {

				SceneManager.LoadScene ("YouWin");
			}
		}
	}
}



