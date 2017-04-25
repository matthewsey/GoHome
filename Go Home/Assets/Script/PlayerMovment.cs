using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {

	Rigidbody rigidbody;
	public float moveSpeed;
	public float maxSpeed= 10f;
	private Vector3 input;

	// Use this for initialization
	void Awake () {

		rigidbody = GetComponent <Rigidbody> ();
		
	}
	
	void Update () {

		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (rigidbody.velocity.magnitude < maxSpeed) {
			
			rigidbody.AddForce (input * moveSpeed);
		}
	}
}
