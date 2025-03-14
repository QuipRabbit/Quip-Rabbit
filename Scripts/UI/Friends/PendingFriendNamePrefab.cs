// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using TMPro;
using UnityEngine;

public class PendingFriendNamePrefab : MonoBehaviour
{
    [SerializeField] private TMP_Text _numberText;
    [SerializeField] private TMP_Text _usernamePlayer;

    public void SetFriendName(string friendName)
    {
        _usernamePlayer.text = friendName;
    }

    public void SetSequenceNumber(int number)
    {
        _numberText.text = number.ToString();
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
