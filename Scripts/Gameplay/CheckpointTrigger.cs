// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    [SerializeField] private Transform checkpointLocation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Bot"))
        {
            CheckpointManager checkpointManager = other.GetComponent<CheckpointManager>();

            if (checkpointManager != null)
            {
                checkpointManager.SetNewCheckpoint(checkpointLocation.position);
            }
        }
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
