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
    [SerializeField] private Image _loadingSpinnerImageForUsername;
    [SerializeField] private Image _loadingSpinnerImageForScore;

    void Start()
    {
        _loadingSpinnerImageForUsername.gameObject.SetActive(true);
        _loadingSpinnerImageForScore.gameObject.SetActive(true);
        _usernameText.gameObject.SetActive(false);
        _yourScoreText.gameObject.SetActive(false);
        GetPlayerRank();
    }

    void GetPlayerRank()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
