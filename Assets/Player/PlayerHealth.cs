using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int playerHealth;
    public int hitDamage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("player health = " + playerHealth);	
	}

    public void DamageHealth(){
        //Debug.LogWarning("Player damaged.");
        playerHealth -= hitDamage;
        if(playerHealth <= 0){
            GameOver();
        }
    }

    public void GameOver(){
        Destroy(gameObject);
    }
}
