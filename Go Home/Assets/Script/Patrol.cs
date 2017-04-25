﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
	public Transform[] patrolPoints;
	public float moveSpeed;
	private int currentPoint;

	// Use this for initialization
	void Awake () {
		transform.position = patrolPoints [0].position;
		currentPoint = 0;
	}

	// Update is called once per frame
	void Update () {

		if (transform.position == patrolPoints [currentPoint].position) {

			currentPoint = (currentPoint + 1) % patrolPoints.Length;

		}

		transform.position = Vector3.MoveTowards (transform.position, patrolPoints [currentPoint].position, moveSpeed * Time.deltaTime);

	}
}
