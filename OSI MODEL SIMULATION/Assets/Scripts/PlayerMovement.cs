

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D mybody;
    private Animator anim;
    private float movementX;
    public bool grounded = true;
    private Vector3 movement;
    Vector3 velocity = new Vector3(0, 0, 0);

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        movement = new Vector3(0, 0, 0);

    }

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //player movement
        movementX = Input.GetAxisRaw("Horizontal");
        movement.x = movementX;
        //transform.position += movement * Time.deltaTime * movementSpeed;
        //do not u se transform.position on a object having rigid body as transform do not care about physics and use movement using teansform
        //can cause wired jitter in game. to test it run above code and comment below three lines
        /*if (movementX == 1 || movementX == -1)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
        if (!gg.CheckGrounded())
        {
            anim.SetBool("walk", false);
            anim.SetBool("jump", true);
        }
        else
        {
            anim.SetBool("jump", false);
        }*/


        playerJump();
    }

    private void FixedUpdate()
    {
        velocity.x = movementX * movementSpeed;
        velocity.y = mybody.velocity.y;
        mybody.velocity = velocity;
    }

    private void playerJump()
    {
        if (Input.GetKeyDown("space") && grounded)
        {
            mybody.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode2D.Impulse);
            grounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = false;
        }
    }

}

