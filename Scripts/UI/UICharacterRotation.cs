// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class UICharacterRotation : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 initialTouchPos;
    private Quaternion rotationY;
    private Quaternion initialRotation; // Store the initial rotation for 3D Character Home, Profile, and NFT Marketplace
    private Quaternion initialRotationMatchmaking; // Store the initial rotation for 3D Character Matchmaking
    [SerializeField] private float rotateSpeedModifier = 0.5f;
    public bool isDisableDragForRotateCharacter;

    public static UICharacterRotation instance;

    private void Awake()
    {
        instance = this;
        initialRotation = Quaternion.Euler(0, 180, 0); // Save the initial rotation
        initialRotationMatchmaking = Quaternion.Euler(0, 170, 0); // Save the initial matchmaking character rotation
    }

    void Update()
    {
        if (!isDisableDragForRotateCharacter)
        {
            
        }
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
