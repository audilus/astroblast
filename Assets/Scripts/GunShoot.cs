using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour {

    public Projectile projectile;
    public Transform gunSocket;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Fire1")){           
            Projectile p = GameObject.Instantiate(projectile, gunSocket.transform.position, transform.rotation);
            p.transform.Rotate(new Vector3(0, 0, -90));
            p.inUse = true;
        }
	}
}
