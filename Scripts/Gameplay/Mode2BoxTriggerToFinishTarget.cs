// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class Mode2BoxTriggerToFinishTarget : MonoBehaviour
{
    public bool isHasTopToFinishTarget;

    public static Mode2BoxTriggerToFinishTarget instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bot"))
        {
            isHasTopToFinishTarget = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bot"))
        {
            isHasTopToFinishTarget = false;
        }
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
