using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerak : MonoBehaviour {

	public float speed = 5f;
	public float jumpspeed = 8f;
	private Rigidbody2D rigidBody;
	private float movement = 0f;
	public Transform groundCheckPoint;
	public float groundCheckRadius;
	public LayerMask groundLayer;
	public bool isTouchingGround;
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position,groundCheckRadius,groundLayer);
		movement = Input.GetAxis("Horizontal");

		if(Input.GetKey(KeyCode.D)){
			rigidBody.velocity = new Vector2(movement*speed,rigidBody.velocity.y);
		}
		if(Input.GetKey(KeyCode.A)){
			rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
		}
		if (Input.GetKey(KeyCode.W) && isTouchingGround){
			rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpspeed);
		}
		{
			
		}
	}
}
