// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class RankManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvasLoadingSpinner;
    [SerializeField] private GameObject _userRankPrefab;
    [SerializeField] private Transform _rankTransform;
    RankPrefab _spawnRankPrefabScript;

    void Start()
    {
        _canvasLoadingSpinner.gameObject.SetActive(true);
        _canvasLoadingSpinner.enabled = true;
        var request = new GetLeaderboardRequest
        {
            StatisticName = "RankScore",
            MaxResultsCount = 100
        };
        PlayFabClientAPI.GetLeaderboard(request, OnGetLeaderboardSuccess, OnError);
    }

    void OnError(PlayFabError error)
    {
        Debug.LogError(error.GenerateErrorReport());
    }

    void OnGetLeaderboardSuccess(GetLeaderboardResult result)
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
