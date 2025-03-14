// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using Newtonsoft.Json.Linq;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;

public class FriendRequestPrefab : MonoBehaviour
{
    [SerializeField] private TMP_Text _numberText;
    [SerializeField] private TMP_Text _usernamePlayer;
    [SerializeField] private TMP_Text _scoreRankPlayer;
    private string _friendPlayFabId;

    public void SetFriendName(string friendName, string friendPlayFabId)
    {
        _usernamePlayer.text = friendName;
        _friendPlayFabId = friendPlayFabId;
    }

    public void SetFriendRequestScoreRank(string scoreRank)
    {
        _scoreRankPlayer.text = scoreRank;
    }

    public void SetSequenceNumber(int number)
    {
        _numberText.text = number.ToString();
    }

    public void AcceptBtn_onClick()
    {
        
    }

    public void RejectBtn_onClick()
    {
        
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
