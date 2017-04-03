using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {

	Rigidbody rigidbody;
	public float moveSpeed;
	private Vector3 input;

	// Use this for initialization
	void Awake () {

		rigidbody = GetComponent <Rigidbody> ();
		
	}
	
	void Update () {

		input = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		rigidbody.AddForce(input * moveSpeed);
		
	}
}
