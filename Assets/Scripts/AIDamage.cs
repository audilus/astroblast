using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDamage : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject == player)
        {
            Debug.Log("hit " + player.name);
            playerHealth.DamageHealth();
        }

    }

	// Update is called once per frame
	void Update () {
		
	}
}
