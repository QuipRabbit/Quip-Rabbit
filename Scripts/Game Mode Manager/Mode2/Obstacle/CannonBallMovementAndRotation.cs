// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class CannonBallMovementAndRotation : MonoBehaviour
{
    private float speed = 10f;
    private float xRotationSpeed = 180f;

    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right * xRotationSpeed * Time.deltaTime, Space.Self);
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
