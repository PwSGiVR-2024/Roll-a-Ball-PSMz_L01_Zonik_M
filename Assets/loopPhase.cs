using UnityEngine;

public class loopPhase : MonoBehaviour
{
    public float newGravityScale = 4f; // The new gravity scale to apply to the player

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the object colliding is the player
        {
            // Get the player's movementController component
            movementController playerController = other.GetComponent<movementController>();

            if (playerController != null)
            {
                // Update the player's gravity scale
                playerController.gravityScale = newGravityScale;
                Debug.Log("Player's gravity scale updated to: " + newGravityScale);
            }
            else
            {
                Debug.LogWarning("Player does not have a movementController component.");
            }

            // Destroy this game object
            Destroy(gameObject);
        }
    }
}
