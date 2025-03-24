// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController characterController;
    private float moveSpeed = 4f;
    private Vector3 movementVelocity;
    PlayerInput playerInput;
    private float verticalVelocity;
    private float gravity = -20f;
    private Animator animator;
    private float jumpForce = 4f;
    private int jumpCount = 0;
    private bool isPunching;
    private bool isJumping;
    private bool hasDoubleJump;
    private bool isValidGround;
    private float pushStrength = 0.75f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
    }

    void CalculateMove()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
