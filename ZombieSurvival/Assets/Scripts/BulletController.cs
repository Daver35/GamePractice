﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public float speed;
	private PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();

		if (player.transform.localScale.x < 0) {
			speed = -speed;
		}
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		Destroy (gameObject);

		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
}