using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOverTime : ExtendedBehavior {

	[Tooltip("Time that the attatched gameobject has to live (in seconds).")]
	public float lifetime = 1f;
	// Use this for initialization
	void Start () {
		Wait(lifetime, () => {
			Destroy(gameObject);
		});
	}
}
