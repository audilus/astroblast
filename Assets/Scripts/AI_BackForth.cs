using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_BackForth : MonoBehaviour {
    //Can or cannot move forward
    public bool forward = true;
    //Character speed
    public int speed = 0;

    //Character movement range
    public int pointA;
    public int pointB;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AIMove();
	}

      void AIMove()
    {
        if (transform.position.x >= pointB){
            forward = false;
        }
        if (transform.position.x <= pointA){
            forward = true;
        }

        if (forward == true){
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            Debug.Log(forward);
        }
        if (forward == false){
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            Debug.Log(forward);
        }
    }
}
