using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private PlayerController player;
	private Vector3 playerStartPoint;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		playerStartPoint = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Allows the player to respawn
	public void RespawnPlayer(){
		Debug.Log ("Player respawn");
		player.transform.position = playerStartPoint;
	}
}
