// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using UnityEngine;
using Unity.Cinemachine;

public class ObjectPreviewSystem : MonoBehaviour
{
    private GameObject previewObject;
    private GameObject previewGridObject;
    [SerializeField] private Material previewMaterialPrefab;
    private Material previewMaterialInstance;
    public GameObject gridObj;
    public CinemachineCamera mainCamera;
    private Vector3 spawnPosition;

    private void Start()
    {
        previewMaterialInstance = new Material(previewMaterialPrefab);
    }

    
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
