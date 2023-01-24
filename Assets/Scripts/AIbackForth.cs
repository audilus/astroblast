using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIbackForth : MonoBehaviour {

	// Use this for initialization
	public bool forward = true;
	public int speed = 0;
	//range of motion
	public int pointA, pointB;
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		AiMovement();
	}
	void AiMovement()
	{
		if(transform.position.x >= pointB)
		{
			forward = false;
		}
		else if(transform.position.x <= pointA)
			forward = true;
		
		if(forward)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed);
		}
		if(!forward)
		{
			transform.Translate(Vector3.left * Time.deltaTime * speed);
		}

	}
}
