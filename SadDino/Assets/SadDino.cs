using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadDino : MonoBehaviour
{

    public float maxVel = 5f;
    private float yJumpForce = 300f;

    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 jumpForce;
    private bool isJumping = false;
    private bool movingRight = true;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        jumpForce = new Vector2(0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //	We update horizontal speed
        float v = Input.GetAxis("Horizontal");
        Vector2 vel = new Vector2(0, rb.velocity.y);

        v *= maxVel;

        vel.x = v;

        rb.velocity = vel;

        //	We change animations if needed
        if (v != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        //	If the player jumps
        if (Input.GetAxis("Jump") > 0.01f)
        {
            if (!isJumping)
            {
                anim.SetBool("isJumping", true);
                isJumping = true;
                if (rb.velocity.y == 0)
                {
                    
                    jumpForce.x = 0f;
                    jumpForce.y = yJumpForce;
                    rb.AddForce(jumpForce);
                }
            }
        }
        else
        {
            anim.SetBool("isJumping", false);
            isJumping = false;
        }

        if (movingRight && v < 0)
        {
            movingRight = false;
            Flip();
        }
        else if (!movingRight && v > 0)
        {
            movingRight = true;
            Flip();
        }
    }

    private void Flip()
    {
        var s = transform.localScale;
        s.x *= -1;
        transform.localScale = s;
    }
}