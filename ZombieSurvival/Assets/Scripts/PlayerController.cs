using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	public Transform gun;
	public GameObject bullet;

	private Animator anim;
	private Rigidbody2D myRigidbody2D;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myRigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Basic player movement
		if(Input.GetKey(KeyCode.A)){
			myRigidbody2D.velocity = new Vector2 (-moveSpeed, myRigidbody2D.velocity.y);
		}
		if(Input.GetKey(KeyCode.D)){
			myRigidbody2D.velocity = new Vector2 (moveSpeed, myRigidbody2D.velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bullet, gun.position, gun.rotation);
		}

		//Animations & player flipping
		anim.SetFloat ("MoveSpeed", Mathf.Abs(myRigidbody2D.velocity.x));
		if (myRigidbody2D.velocity.x > 0) {
			transform.localScale = new Vector3 (1f, 1f, 1f);
		} else if (myRigidbody2D.velocity.x < 0){
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
	}
}
