using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5.0f; // Adjust this to control the jump force
    private bool isGrounded = true; // Check if the player is grounded

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Handle jumping
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Apply an upward force to make the player jump
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
