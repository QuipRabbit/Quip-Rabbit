// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class MenuBackgroundMusic : MonoBehaviour
{
    [SerializeField] private AudioClip _menuBGMClip;
    [SerializeField] private AudioSource _menuBGMSource;

    void Start()
    {
        _menuBGMSource.Play();
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
