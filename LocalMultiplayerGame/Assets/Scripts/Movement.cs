using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    private Rigidbody2D rb;

    public float speed;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector2.right * speed);
        }
        
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector2.left * speed);
        }
    }
}
