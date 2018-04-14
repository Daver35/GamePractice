using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float moveSpeed;
    Transform target;

    // Use this for initialization
    void Start () {
        target = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        //Calculate direction
        float dir = target.position.x - GetComponent<Rigidbody2D>().position.x;

        if (dir > 0)//Right
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (dir < 0)//Left
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

    }
}
