using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	private Rigidbody2D myRigidBody;
	public float moveSpeed;
	private Animator anim;

	// Use this for initialization
	void Start () 
	{
		myRigidBody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void FixedUpdate()
	{
		Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		anim.SetFloat("x", (int)direction.x);

		myRigidBody.velocity = direction * moveSpeed * Time.deltaTime;

			
	}
}
