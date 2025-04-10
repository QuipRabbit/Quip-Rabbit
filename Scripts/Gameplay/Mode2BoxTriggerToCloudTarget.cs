// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class Mode2BoxTriggerToCloudTarget : MonoBehaviour
{
    public bool isHasTopToCloudTarget;

    public static Mode2BoxTriggerToCloudTarget instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bot"))
        {
            isHasTopToCloudTarget = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bot"))
        {
            isHasTopToCloudTarget = false;
        }
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
