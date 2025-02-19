// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class CheckInternetConnection : MonoBehaviour
{
    [SerializeField] private GameObject _noInternetConnectionText;
    [SerializeField] private GameObject _internetAvailableText;

    public static CheckInternetConnection instance;

    private void Awake()
    {
        instance = this;
    }

    public void CheckNetwork()
    {
        InvokeRepeating(nameof(ReexaminationProcess), 1, 1);
    }

    void ReexaminationProcess()
    {
        StartCoroutine(CheckProcessing());
    }

    IEnumerator CheckProcessing()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
