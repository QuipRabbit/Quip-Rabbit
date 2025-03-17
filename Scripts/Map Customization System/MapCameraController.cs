// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using Unity.Cinemachine;
using UnityEngine;

public class MapCameraController : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float rotateSpeed = 5f;
    public float zoomSpeed = 20f;
    public float minZoom = 5f;
    public float maxZoom = 30f;

    private Vector3 movementVelocity;
    private Vector2 lastMousePosition;
    private bool isRotating = false;

    public float horizontalInput;
    public float verticalInput;

    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private RectTransform panelJoystickRect;
    [SerializeField] private RectTransform panelMapObjectsRect;
    private CinemachineCamera cinemachineCamera;
    private float targetFOV = 100f;
    public float gravity = -20f;

    [SerializeField] private ObjectPlacementSystem objectPlacementSystem;

    private void Awake()
    {
        cinemachineCamera = GetComponent<CinemachineCamera>();
    }

    private void Start()
    {
        targetFOV = cinemachineCamera.Lens.FieldOfView;
    }

    private void Update()
    {
        if (!objectPlacementSystem.isDetectClickOrDragObject)
        {
            HandleRotation();
        }
        if (!isRotating)
        {
            HandleMovement();
            HandleZoom();
        }
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
