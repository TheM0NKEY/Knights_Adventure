using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	private Rigidbody2D myRigidBody;
	public float moveSpeed;

	// Use this for initialization
	void Start () 
	{
		myRigidBody = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void FixedUpdate()
	{
		Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		myRigidBody.velocity = direction * moveSpeed * Time.deltaTime;

			
	}
}
