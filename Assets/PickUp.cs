using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public int scoreValue = 10; // Make sure this line is in your PickupItem script

public class PickupItem : MonoBehaviour
{
    public int scoreValue = 10; // Make sure this line is in your PickupItem script

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue);
            }

            gameObject.SetActive(false); // Deactivate the pickup item
        }

        // Check if the colliding object is the player (you can use tags or layers for this)
        if (other.CompareTag("Player"))
        {
            // Add your pickup logic here
            // For example, you can increase the player's score, play a sound, deactivate the pickup item, etc.

            // Deactivate the pickup item
            gameObject.SetActive(false);
        
        }
    }
}
