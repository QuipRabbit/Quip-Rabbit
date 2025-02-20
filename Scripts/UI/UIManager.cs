// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvasHome;
    [SerializeField] private Canvas _canvasSettings;
    [SerializeField] private Canvas _canvasProfile;
    [SerializeField] private Canvas _canvasParty;
    [SerializeField] private Canvas _canvasRoom;
    [SerializeField] private Canvas _canvasFriends;
    [SerializeField] private Canvas _canvasFriendRequest;
    [SerializeField] private Canvas _canvasRank;
    [SerializeField] private Canvas _canvasNFTMarketplace;
    [SerializeField] private Canvas _canvasMatchmaking;
    [SerializeField] private Canvas _canvasWinP2E;
    [SerializeField] private GameObject _rabbitHome3D;
    [SerializeField] private GameObject _rabbitProfileAndNFTMarketplace3D;
    [SerializeField] private GameObject _rabbitMatchmaking3D;
    [SerializeField] private GameObject _renderTextureCharacterCamera;
    [SerializeField] private GameObject _lightingCollections;
    [SerializeField] private TMP_Text _usernameText;

    void Start()
    {
        PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest()
        {
            PlayFabId = PlayFabSettings.staticPlayer.PlayFabId
        },
        result =>
        {
            string username = result.AccountInfo.Username;
            _usernameText.text = username;
        },
        error =>
        {
            Debug.Log(error.GenerateErrorReport());
        });
    }

    #region Open Button On Click
    public void OpenSettingsBtn_onClick()
    {
        _canvasSettings.gameObject.SetActive(true);
        _canvasSettings.enabled = true;
    }

    public void OpenProfileBtn_onClick()
    {
        _canvasProfile.gameObject.SetActive(true);
        _canvasProfile.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(true);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(true);
        _lightingCollections.SetActive(true);
    }

    public void OpenPartyBtn_onClick()
    {
        _canvasParty.gameObject.SetActive(true);
        _canvasParty.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(false);
        _lightingCollections.SetActive(false);
    }

    public void OpenRoomBtn_onClick()
    {
        _canvasRoom.gameObject.SetActive(true);
        _canvasRoom.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(false);
        _lightingCollections.SetActive(false);
    }

    public void OpenFriendsBtn_onClick()
    {
        _canvasFriends.gameObject.SetActive(true);
        _canvasFriends.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(false);
        _lightingCollections.SetActive(false);
    }

    public void OpenFriendRequestBtn_onClick()
    {
        _canvasFriendRequest.gameObject.SetActive(true);
        _canvasFriendRequest.enabled = true;
        _canvasFriends.gameObject.SetActive(false); // This is parent of Friend Request menu screen so we can hide this
        _canvasFriends.enabled = false; // This is parent of Friend Request menu screen so we can hide this
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(false);
        _lightingCollections.SetActive(false);
    }

    public void OpenRankBtn_onClick()
    {
        _canvasRank.gameObject.SetActive(true);
        _canvasRank.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(false);
        _lightingCollections.SetActive(false);
    }

    public void OpenNFTMarketplaceBtn_onClick()
    {
        _canvasNFTMarketplace.gameObject.SetActive(true);
        _canvasNFTMarketplace.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(true);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(true);
        _lightingCollections.SetActive(true);
    }

    public void OpenMatchmakingBtn_onClick()
    {
        _canvasMatchmaking.gameObject.SetActive(true);
        _canvasMatchmaking.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(true);
        _renderTextureCharacterCamera.SetActive(true);
        _lightingCollections.SetActive(true);
    }

    public void OpenWinP2EBtn_onClick()
    {
        _canvasWinP2E.gameObject.SetActive(true);
        _canvasWinP2E.enabled = true;
        _canvasHome.gameObject.SetActive(false);
        _canvasHome.enabled = false;
        _rabbitHome3D.SetActive(false);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(false);
        _lightingCollections.SetActive(false);
    }
    #endregion

    #region Close Button On Click
    public void CloseBtn_onClick()
    {
        _canvasSettings.gameObject.SetActive(false);
        _canvasSettings.enabled = false;
        _canvasProfile.gameObject.SetActive(false);
        _canvasProfile.enabled = false;
        _canvasParty.gameObject.SetActive(false);
        _canvasParty.enabled = false;
        _canvasRoom.gameObject.SetActive(false);
        _canvasRoom.enabled = false;
        _canvasFriends.gameObject.SetActive(false);
        _canvasFriends.enabled = false;
        _canvasFriendRequest.gameObject.SetActive(false);
        _canvasFriendRequest.enabled = false;
        _canvasRank.gameObject.SetActive(false);
        _canvasRank.enabled = false;
        _canvasNFTMarketplace.gameObject.SetActive(false);
        _canvasNFTMarketplace.enabled = false;
        _canvasMatchmaking.gameObject.SetActive(false);
        _canvasMatchmaking.enabled = false;
        _canvasWinP2E.gameObject.SetActive(false);
        _canvasWinP2E.enabled = false;
        _canvasHome.gameObject.SetActive(true);
        _canvasHome.enabled = true;
        _rabbitHome3D.SetActive(true);
        _rabbitProfileAndNFTMarketplace3D.SetActive(false);
        _rabbitMatchmaking3D.SetActive(false);
        _renderTextureCharacterCamera.SetActive(false);
        _lightingCollections.SetActive(true);
    }
    #endregion
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
