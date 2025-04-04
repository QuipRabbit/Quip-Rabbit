// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSpawnManager : MonoBehaviour
{
    // Round 1
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject botPrefab;
    [SerializeField] private Button jumpBtn;
    [SerializeField] private Button punchBtn;
    private int botsPerRow = 6;
    private int totalCharacters = 12;
    private float spacing = 1.25f;
    private Vector3 startPosition = new Vector3(-3.30f, 0, 0);
    PlayerInput jumpAction;
    PlayerControl punchAction;

    public CinemachineCamera[] cinemachineCams;
    public int currentCamIndex = 0;

    void Start()
    {
        cinemachineCams = new CinemachineCamera[totalCharacters];
        SpawnCharacters();
    }

    #region Spectator Camera
    public void OnClickNextCam()
    {
        
    }


    
    #endregion

    void SpawnCharacters()
    {
        
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
