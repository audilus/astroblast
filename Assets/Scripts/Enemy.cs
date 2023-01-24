using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int hitPoints = 3;
    public bool shootThrough = true;

    public LayerMask projectileLayer;
    public Inventory inventory; //Reference to the enemy's coins and items.

    private Rigidbody2D rBody;

	// Use this for initialization
	void Start () {
        //Make sure the enemy spawns with an inventory on its gameobject.
        if (gameObject.GetComponent<Inventory>() == null){
            inventory = gameObject.AddComponent<Inventory>();
        }
        rBody = gameObject.GetComponent<Rigidbody2D>();
	}

	 void OnCollisionEnter2D(Collision2D collision)
	{
       // Debug.Log("Enemy: " + gameObject.name + " was hit by collider " + collision.gameObject.name);
//Debug.Log(collision.otherCollider.name);
        if(collision.collider.gameObject.GetComponent<Projectile>() != null){
            
            ContactPoint2D contact = collision.contacts[0];
            rBody.AddForce(contact.relativeVelocity, ForceMode2D.Impulse);
            if (!shootThrough)
            {
               // Debug.Log(collision.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
            hitPoints--;

           

           // Debug.Log(hitPoints);
            if (hitPoints <= 0)
            {
              //  Debug.Log("DIe.");
                Destroy(gameObject);
                //inventory.spill();

            }
        }

	}

	// Update is called once per frame
	void FixedUpdate () {
        if (hitPoints <= 0)
        {
           // Debug.Log("DIe.");
            inventory.spill();
            Destroy(gameObject);
        }
	}
}
