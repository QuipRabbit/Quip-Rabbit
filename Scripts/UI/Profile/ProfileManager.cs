// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _usernameText;
    [SerializeField] private TMP_Text _yourScoreText;
    [SerializeField] private Image _spinnerImageUsername;
    [SerializeField] private Image _spinnerImageScore;

    void Start()
    {
        _spinnerImageUsername.gameObject.SetActive(true);
        _spinnerImageScore.gameObject.SetActive(true);
        _usernameText.gameObject.SetActive(false);
        _yourScoreText.gameObject.SetActive(false);
        GetPlayerRank();
    }

    void GetPlayerRank()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
