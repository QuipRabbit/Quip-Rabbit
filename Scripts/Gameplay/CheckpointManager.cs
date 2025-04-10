// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Vector3 currentCheckpoint;

    void Start()
    {
        currentCheckpoint = transform.position; // Initial character spawn position
    }

    public void SetNewCheckpoint(Vector3 newCheckpoint)
    {
        currentCheckpoint = newCheckpoint;
    }

    public void TeleportToCheckpoint()
    {
        transform.position = currentCheckpoint;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null && !rb.isKinematic)
        {
            rb.linearVelocity = Vector3.zero;
        }
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
