// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using TMPro;
using Unity.Cinemachine;
using UnityEngine;

public class ObjectPlacementSystem : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private ObjectsDatabaseSO database;
    [SerializeField] private AudioSource source;
    [SerializeField] private Camera sceneCamera;
    [SerializeField] private ObjectPreviewSystem objectPreviewSystem;
    [SerializeField] private EditTransformSystem editTransformSystem;
    [SerializeField] private CinemachineCamera cinemachineCamera;
    public Canvas canvasMaxObject;
    public TMP_Text textCurrentObject;
    public int currentObjCount;

    private bool isFirstPlaceObject;
    private GameObject obj;
    private GameObject newClickobj;
    private int selectedObjectIndex = -1;
    private bool isDragging = false;
    public bool isStartClickOrDragObject = false;
    public bool isDetectClickOrDragObject;

    private Vector3 originalPosition;
    private Quaternion saveRotation;
    private int newgetCurrentObjId;

    private void Start()
    {
        StopPlacement();
    }

    public void StartPlacement(int ID)
    {
        
    }
 

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
