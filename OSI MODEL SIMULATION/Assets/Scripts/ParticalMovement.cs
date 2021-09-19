using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalMovement : MonoBehaviour
{
    private float movementX;
    private float movementY;
    private Vector3 movement = new Vector3(0,0,0);
    public Rigidbody2D mybody;
    Vector3 velocity = new Vector3(0, 0, 0);
    public float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movement.x = movementX;        
        movementY = Input.GetAxisRaw("Vertical");
        movement.y = movementX;
    }

    private void FixedUpdate()
    {
        velocity.x = movementX * movementSpeed;
        velocity.y = movementY * movementSpeed;
        mybody.velocity = velocity;
        if(GameManager.isCorrupted)
            this.GetComponent<SpriteRenderer>().color = GameManager.corruptColor;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            GameManager.isCorrupted = true;
            this.GetComponent<SpriteRenderer>().color = GameManager.corruptColor;
        }
    }
}
