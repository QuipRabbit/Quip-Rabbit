// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using TMPro;
using UnityEngine;

public class UserSearchPrefab : MonoBehaviour
{
    [SerializeField] private TMP_Text _usernamePlayer;
    [SerializeField] private TMP_Text _scoreRankPlayer;

    public void SetFriendName(string friendName)
    {
        _usernamePlayer.text = friendName;
    }

    public void SetFriendRequestScoreRank(string scoreRank)
    {
        _scoreRankPlayer.text = scoreRank;
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
