using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float moveSpeed = 100;
    public float timeout;

    private Collider2D c;

    public ParticleSystem impactEffect;
    public int damage = 10;

    [Tooltip("Determines whether the projectile will fly away and murderize things.")]
    public bool inUse = false;

    [Tooltip("Layers to ignore")]
    public LayerMask[] ignoreLayers;

    [SerializeField]
    private GameObject owner;

    // Use this for initialization
    void Start()
    {
        c = gameObject.GetComponent<Collider2D>();
        Physics.IgnoreLayerCollision(9,9, true);
        // sceneProjectiles.Add(this);
    }
    void SetOwner(GameObject g){

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("HIT: " + collision.gameObject.name);
        if (collision.gameObject.tag != "Default")
        {
            if (collision.gameObject.tag == "Enemy")
            {
               // Debug.Log(collision.gameObject.name);
                //GameObject e = collision.gameObject;
                //Debug.Log(this.name + " has been hit.");
                //e.health -= this.damage;
                //Debug.DrawLine(collision.contacts[0].normal, collision.contacts[0].normal * impactMultiplier,
                //Color.green, 10);
                //e.GetRigidbody().AddForce(collision.contacts[0].normal * impactMultiplier * 100, ForceMode.Impulse);

            }

            Instantiate(impactEffect, collision.contacts[0].point, new Quaternion(0, 0, 0, 0));
        }
        Destroy(gameObject);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, moveSpeed, 0);
        timeout -= Time.fixedDeltaTime;
        if (timeout <= 0 && inUse)
        {
            // sceneProjectiles.Remove(this);
            Destroy(gameObject);
        }
    }
}
