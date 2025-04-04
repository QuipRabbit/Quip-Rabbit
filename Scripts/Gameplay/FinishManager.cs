// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishManager : MonoBehaviour
{
    public bool isHasFinish;
    public bool isHasFinishPlayer;
    private int currentPositionNumber;
    [SerializeField] private TMP_Text currentPositionText;
    [SerializeField] private Button jumpBtn;
    [SerializeField] private Button punchBtn;
    [SerializeField] private RectTransform panelJoystick;
    [SerializeField] private Canvas canvasSpectatorCam;
    private Vector3 freezePosition;
    public List<GameObject> finishedChar = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private IEnumerator FreezePosition(GameObject other)
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
