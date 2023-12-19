using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    private Rigidbody2D rb;
    private Vector2 velocity;

    public float jumpHeight;
    public float speed;
    public float maxSpeed;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        velocity = rb.velocity;
    }


    void FixedUpdate(){
        //rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector2.right * speed);
        }
        
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector2.left * speed);
        }

        if (Input.GetKeyDown("w")){
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }  
    }
}
