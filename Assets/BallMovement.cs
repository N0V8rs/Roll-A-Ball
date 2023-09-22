using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5.0f; // Adjust this to control the speed of the ball

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a movement vector based on the input
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        // Apply force to the ball's rigidbody to move it
        rb.AddForce(movement * speed);
    }
}
