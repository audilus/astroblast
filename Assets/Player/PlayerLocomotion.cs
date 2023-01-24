using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : ExtendedBehavior
{
    [Header("General Movement")]
    public float moveScale;
    public float dampening;
    public float maxVelocity;
    public float fastFallScale; //juice that makes you go oof
    
    [Range(0.5f, 1f)]
    public float decayRate = 0.82f;
    [Header("Jump Settings")]
    public float jumpScale = 400f;

    public float jumpRayDistance = 2f;
    public LayerMask groundMask;
    public int jumpCount = 2;
    public float groundDistance;

    public bool isJumping;// Pay careful attention to the state of this variable

    private Rigidbody2D rBody;
    private Collider2D collision;
    private float velocityX;
    private float velocityY;

    public int jc;

    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        collision = GetComponent<Collider2D>();
        jc = jumpCount;
        groundDistance = collision.bounds.extents.y;
    }

    //Reset this variable
    private void SetJumpingFalse()
    {
        isJumping = false;
    }

    private void resetJumpCount()
    {
        if(isGrounded())
            jc = jumpCount;
    }
    private bool isGrounded()
    {
        var hit = Physics2D.Raycast(transform.position, Vector2.down, jumpRayDistance, groundMask);
        return hit.collider != null;
    }
    private void Jump()
    {
        var hit = Physics2D.Raycast(transform.position, Vector2.down, jumpRayDistance, groundMask);
        bool grounded = hit.collider != null;
        if (grounded){
            velocityY = jumpScale;
        }
    }

    // Called every physics tick
    void FixedUpdate()
    {
        
        //Decay rate from Henry's thing
        rBody.velocity *= new Vector2(decayRate, 1f);
        
        #region Jump
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        #endregion
        if (Mathf.Abs(Input.GetAxisRaw("Vertical")) < 0){
            velocityY += -fastFallScale;
        }

        //raycast
        var hit = Physics2D.Raycast(transform.position, new Vector2(0, -1), .5f, groundMask);
        bool onGround = (hit.collider != null);

        Debug.Log("On Ground: " + onGround);

        //Horizontal Control
        #region Horizontal
        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0)
        {
            if (Mathf.Abs(rBody.velocity.x) <= maxVelocity)
                velocityX += 1 * Input.GetAxisRaw("Horizontal") * moveScale;
            Debug.Log("Jump");  }
        else
        {
            //TODO: make this editable
            velocityX = rBody.velocity.x * dampening;
        }
        rBody.AddForce(new Vector2(velocityX, velocityY));
        //Debug.Log("CURRENT SPEED: " + rigidbody.velocity.x +", "+ rigidbody.velocity.y);
        #endregion
        
    }
    void Update()
    {
        velocityY = 0;
        velocityX = 0;
        // #region Control

        // // #region Vertical
        // // if (isJumping)
        // // {
        // //     Action a = new Action(SetJumpingFalse);
        // //     Wait(jumpAscendTime, a);
        // //     //SetJumpingFalse();
        // // }
        // // else
        // // {
        // //     velocityY += 1 * Physics2D.gravity.y * Time.fixedDeltaTime;
        // //     resetJumpCount();
        // // }

        // // //FastFall
        // // if (Input.GetAxisRaw("Vertical") < 0)
        // //     velocityY += -1 * Mathf.Abs(Input.GetAxisRaw("Vertical")) * fastFallScale;
        // // #endregion

        // #endregion


    }
}
