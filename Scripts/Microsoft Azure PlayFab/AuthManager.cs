// After the Quip Rabbit token pre-sale is successful and completed. We will update the latest and complete code, thank you.

using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.DataModels;
using System.Collections.Generic;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class AuthManager : MonoBehaviour
{
    public static AuthManager instance;

    private void Awake()
    {
        instance = this;
        _registerFormAnim = _registerForm.GetComponent<Animator>();
    }

    public void DetectAccount()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = false
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccessDetectAccount, OnErrorDetectAccount);
    }

    private void CreateAccount()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccessCreateAccount, OnErrorCreateAccount);
    }

    // Detect Account for Android Device
#if UNITY_ANDROID
    public void DetectAccount_AndroidDevice()
    {
        var request = new LoginWithAndroidDeviceIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = false
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccessDetectAccount, OnErrorDetectAccount);
    }

    private void CreateAccount_AndroidDevice()
    {
        var request = new LoginWithAndroidDeviceIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccessCreateAccount, OnErrorCreateAccount);
    }
#endif

    // Detect Account for iOS Device
#if UNITY_IOS
    public void DetectAccount_AndroidDevice()
    {
        var request = new LoginWithIOSDeviceIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = false
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccessDetectAccount, OnErrorDetectAccount);
    }

    private void CreateAccount_AndroidDevice()
    {
        var request = new LoginWithIOSDeviceIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccessCreateAccount, OnErrorCreateAccount);
    }
#endif

    void OnSuccessDetectAccount(LoginResult result)
    {
        GoToHome();
    }

    void OnSuccessCreateAccount(LoginResult result)
    {
        var playerProfile = result.InfoResultPayload.PlayerProfile;
        entityId = result.EntityToken.Entity.Id;
        entityType = result.EntityToken.Entity.Type;
        string playfabid = result.PlayFabId;
        AddLocation(playfabid);
    }

    void AddLocation(string playFabId)
    {
        
    }
}

// After the Quip Rabbit token pre-sale is successful and completed. We will update the latest and complete code, thank you.
