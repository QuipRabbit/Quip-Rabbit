// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using Unity.Cinemachine;
using UnityEngine;

public class GameCameraController : MonoBehaviour
{
    [SerializeField] private CinemachineCamera cinemachineCamera;
    private CinemachineFollow _transposer;
    private Vector3 _followOffset;
    public float rotationSpeed = 5f;

    private Vector2 _previousPosition;
    private bool _isDragging;
    [SerializeField] private RectTransform panelJoystickRect;

    private void Awake()
    {
        StartCoroutine(WaitPanelJoystick());
    }

    IEnumerator WaitPanelJoystick()
    {
        yield return new WaitForSeconds(4f);
        panelJoystickRect = GameObject.FindWithTag("PanelJoystick").GetComponent<RectTransform>();
    }

    private void Start()
    {
        
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
