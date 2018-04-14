using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	public Transform gun;
	public GameObject bullet;

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Basic player movement
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bullet, gun.position, gun.rotation);
		}

		//Animations & player flipping
		anim.SetFloat ("MoveSpeed", Mathf.Abs(GetComponent<Rigidbody2D> ().velocity.x));
		if (GetComponent<Rigidbody2D> ().velocity.x > 0) {
			transform.localScale = new Vector3 (1f, 1f, 1f);
		} else if (GetComponent<Rigidbody2D> ().velocity.x < 0){
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
	}
}
