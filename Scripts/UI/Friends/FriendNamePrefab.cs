// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using Newtonsoft.Json.Linq;
using PlayFab;
using PlayFab.ClientModels;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FriendNamePrefab : MonoBehaviour
{
    [SerializeField] private TMP_Text _numberText;
    [SerializeField] private TMP_Text _usernamePlayer;
    [SerializeField] private TMP_Text _scoreRankPlayer;
    [SerializeField] private TMP_Text _statsText;
    [SerializeField] private Image _redStatsImage;
    [SerializeField] private Image _greenStatsImage;
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

    public void LoadFriendData(string lastactivekey, string friendPlayFabId)
    {
        _friendPlayFabId = friendPlayFabId;
        PlayFabClientAPI.GetUserData(new GetUserDataRequest
        {
            PlayFabId = _friendPlayFabId
        }, result =>
        {
            if (result.Data != null)
            {
                string lastactivevalue = result.Data.ContainsKey(lastactivekey) ? result.Data[lastactivekey].Value : null;

                if (string.IsNullOrEmpty(lastactivevalue))
                {
                    _statsText.text = "On";
                    _redStatsImage.gameObject.SetActive(false);
                    _greenStatsImage.gameObject.SetActive(true);
                }
                else
                {
                    DateTime lastActiveTime = DateTime.Parse(lastactivevalue, null, System.Globalization.DateTimeStyles.RoundtripKind);
                    DateTime currentTime = DateTime.UtcNow;
                    TimeSpan difference = currentTime - lastActiveTime;

                    if (difference.TotalMinutes > 10) // 10 minutes to set friend player to offline
                    {
                        _statsText.text = "Off";
                        _redStatsImage.gameObject.SetActive(true);
                        _greenStatsImage.gameObject.SetActive(false);
                    }
                    else
                    {
                        _statsText.text = "On";
                        _redStatsImage.gameObject.SetActive(false);
                        _greenStatsImage.gameObject.SetActive(true);
                    }
                }
            }
        }, error =>
        {
            Debug.LogError($"Error friend load activity: {error.ErrorMessage}");
        });
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
