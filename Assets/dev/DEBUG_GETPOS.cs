using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUG_GETPOS : MonoBehaviour {

	public bool isEnabled;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isEnabled)
			Debug.Log(this.name + " world pos: " + transform.position);
	}
}
