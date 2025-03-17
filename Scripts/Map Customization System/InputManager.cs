// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Camera sceneCamera;
    [SerializeField] private float gridHeight = 0f;
    [SerializeField] private ObjectPlacementSystem objectPlacementSystem;

    public event Action OnDragStart, OnDragging, OnDragEnd;

    private bool isDragging = false;
    private Vector3 startPointerPosition;
    private float dragThreshold = 0.1f;
    public bool IsDraggingActive => isDragging;

    private void Awake()
    {
        Input.simulateMouseWithTouches = false; // Faster Performance for Mobile + PC
    }

    private void LateUpdate()
    {
        if (IsPointerOverUI()) return;

        if (!isDragging) objectPlacementSystem.DetectObjectClick();

        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            startPointerPosition = Input.mousePresent ? Input.mousePosition : (Vector3)Input.GetTouch(0).position;
            isDragging = false;
        }

        if ((Input.GetMouseButton(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)))
        {
            
        }
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
