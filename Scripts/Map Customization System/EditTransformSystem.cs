// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EditTransformSystem : MonoBehaviour
{
    [SerializeField] private float moveStep = 0.1f;
    private Renderer objectRenderer;
    private Material originalMaterial;
    [SerializeField] private Material outlineMaterial;
    public GameObject selectedObject { get; private set; }
    private GameObject selectedGrid;

    [SerializeField] private Slider XrotationSlider;
    [SerializeField] private Slider YrotationSlider;
    [SerializeField] private Slider ZrotationSlider;

    private Quaternion initialRotation;
    private float xValue, yValue, zValue;
    public bool isHasRotate;

    [SerializeField] private ObjectPlacementSystem objectPlacementSystem;

    private void Start()
    {
        
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
