// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using PlayFab;
using PlayFab.ClientModels;
using System.Collections;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserSearchManager : MonoBehaviour
{
    public Canvas _canvasFriendRequestInformationDialogBox;
    [SerializeField] private Canvas _canvasUserSearch;
    [SerializeField] private Canvas _canvasLoadingSpinner;
    [SerializeField] private Canvas _canvasLoadingSpinnerFriendRequestInformation;
    [SerializeField] private Transform _userPlaceContent;
    [SerializeField] private GameObject _userSearchPrefab;
    [SerializeField] private TMP_InputField _userSearchInputField;
    [SerializeField] private TMP_Text _userErrorText;
    [SerializeField] private TMP_Text _friendRequestSuccessText;
    [SerializeField] private TMP_Text _friendRequestErrorText;
    [SerializeField] private Button _sendFriendInvitationBtn;
    [SerializeField] private Animator _mainFriendRequestInformation;
    private string getUsernameSearchSave; // Save same username so can't double user search
    private string getUserPlayFabId;

    public static UserSearchManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        _userSearchInputField.onValueChanged.AddListener(ValidateUsername);
    }

    private void OnDisable()
    {
        _userSearchInputField.onValueChanged.RemoveListener(ValidateUsername);
    }

    public void CloseBtn_onClick()
    {
        StopAllCoroutines();
        DestroyAllChildUserPlacePrefab();
        _userSearchInputField.text = "";
        _userErrorText.gameObject.SetActive(false);
        _canvasLoadingSpinner.gameObject.SetActive(false);
        _canvasLoadingSpinner.enabled = false;
        _canvasUserSearch.gameObject.SetActive(false);
        _canvasUserSearch.enabled = false;
        _sendFriendInvitationBtn.gameObject.SetActive(false);
    }

    private void ValidateUsername(string input)
    {
        
    }

    public void UserSearch()
    {
        
    }

    private IEnumerator UserSearchWaiting()
    {
        
    }

    private void DestroyAllChildUserPlacePrefab()
    {
        if (_userPlaceContent.transform.childCount == 0) return;

        for (int i = 0; i < _userPlaceContent.transform.childCount; i++)
        {
            Destroy(_userPlaceContent.transform.GetChild(i).gameObject);
        }
    }

    public void SendFriendInvitationBtn_onClick()
    {
        
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
