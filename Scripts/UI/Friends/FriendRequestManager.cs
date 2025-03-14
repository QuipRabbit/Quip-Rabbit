// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using PlayFab;
using PlayFab.ClientModels;
using System.Collections;
using UnityEngine;

public class FriendRequestManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvasUserSearch;
    [SerializeField] private Canvas _canvasLoadingSpinner;
    [SerializeField] private Transform _friendRequestPlaceScrollViewContent;
    [SerializeField] private GameObject _friendRequestPrefab;
    public Animator _mainUserSearch;
    private int friendCounter = 1;

    public static FriendRequestManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        DestroyAllChildFriendRequestPrefab();
        StartCoroutine(GetFriendsRequestList());
    }

    private void DestroyAllChildFriendRequestPrefab()
    {
        if (_friendRequestPlaceScrollViewContent.transform.childCount == 0) return;

        for (int i = 0; i < _friendRequestPlaceScrollViewContent.transform.childCount; i++)
        {
            Destroy(_friendRequestPlaceScrollViewContent.transform.GetChild(i).gameObject);
        }
    }

    public void UserSearchBtn_onClick()
    {
        _canvasUserSearch.gameObject.SetActive(true);
        _canvasUserSearch.enabled = true;
        _canvasLoadingSpinner.gameObject.SetActive(false);
        _canvasLoadingSpinner.enabled = false;
        _mainUserSearch.SetBool("TriggerDialogBoxAnim", true);
    }

    IEnumerator GetFriendsRequestList()
    {
        _canvasLoadingSpinner.gameObject.SetActive(true);
        _canvasLoadingSpinner.enabled = true;
        yield return new WaitForSeconds(2f);
        _canvasLoadingSpinner.gameObject.SetActive(false);
        _canvasLoadingSpinner.enabled = false;
        friendCounter = 1;
        var getFriendsList = new GetFriendsListRequest();

        PlayFabClientAPI.GetFriendsList(getFriendsList, result =>
        {
            foreach (FriendInfo friendInfo in result.Friends)
            {
                
            }
        }, error =>
        {
            Debug.LogError($"Error get friend list: {error.ErrorMessage}");
        });
    }

    private void GetFriendScoreRank(string statisticName, string friendPlayFabId, FriendRequestPrefab prefabScript)
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
