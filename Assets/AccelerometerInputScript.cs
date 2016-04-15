﻿using UnityEngine;
using System.Collections;

public class AccelerometerInputScript : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.acceleration.x;
		float moveVertical = Input.acceleration.z;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}