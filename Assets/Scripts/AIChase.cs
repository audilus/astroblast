using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour {

    public GameObject player;
    Vector2 target;
    public int speed;
    public bool trigger;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if(trigger)
        {
            target = player.transform.position;
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
	}

    public void triggertoggle()
    {
        trigger = !trigger;
    }
}
