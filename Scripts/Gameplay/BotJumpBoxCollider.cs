// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class BotJumpBoxCollider : MonoBehaviour
{
    private float jumpForce = 5f;
    private float moveSpeed = 3f;
    public bool isBotJump;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bot"))
        {
            Rigidbody botRb = other.GetComponent<Rigidbody>();
            if (botRb != null)
            {
                isBotJump = true;
                botRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                Vector3 forwardDirection = other.transform.forward * moveSpeed;
                botRb.AddForce(forwardDirection, ForceMode.Impulse);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bot"))
        {
            Rigidbody botRb = other.GetComponent<Rigidbody>();
            if (botRb != null)
            {
                isBotJump = false;
            }
        }
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
