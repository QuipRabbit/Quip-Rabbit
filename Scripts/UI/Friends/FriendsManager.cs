// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using PlayFab;
using PlayFab.ClientModels;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FriendsManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvasFriendsList;
    [SerializeField] private Canvas _canvasPending;
    [SerializeField] private Canvas _canvasLoadingSpinner;
    [SerializeField] private Transform _friendsListPlaceScrollViewContent;
    [SerializeField] private Transform _pendingPlaceScrollViewContent;
    [SerializeField] private GameObject _friendsPrefab;
    [SerializeField] private GameObject _pendingPrefab;
    public bool isFriendsListEmpty;
    public bool isPendingListEmpty;
    private bool isFriendsListClick;
    private bool isPendingListClick;
    private bool isFriendListHasClick;
    private bool isPendingListHasClick;
    private int friendCounter = 1;
    public Toggle _friedsListToggle;
    public Toggle _pendingListToggle;

    public static FriendsManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        isFriendListHasClick = true;
        FriendsListToggleRun();
    }

    private void OnEnable()
    {
        StopAllCoroutines();

    }

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
