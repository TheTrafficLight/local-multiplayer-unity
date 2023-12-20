using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementtesting : MonoBehaviour
{
    public string horizontalInputAxis = "Horizontal";
    public string verticalInputAxis = "Vertical";

    public int playerIndex = 1;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis(horizontalInputAxis);
        float verticalInput = Input.GetAxis(verticalInputAxis);

        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        movement.Normalize();

        transform.Translate(movement * speed * Time.deltaTime);

    }

}
