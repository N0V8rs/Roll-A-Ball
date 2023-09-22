using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform target; // Drag your ball GameObject here in the Inspector
    public Vector3 offset = new Vector3(0, 5, -10); // Adjust this to set the camera position relative to the ball

    private void Update()
    {
        if (target != null)
        {
            // Update the camera's position to follow the ball
            transform.position = target.position + offset;
        }
    }
}

