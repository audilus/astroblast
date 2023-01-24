using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasetrigger : MonoBehaviour {

    public GameObject flying;
    public AIChase flyingscript;

	// Use this for initialization
	void Start () {
        flyingscript = flying.GetComponent<AIChase>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            flyingscript.triggertoggle();

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            flyingscript.triggertoggle();

        }
    }
}
