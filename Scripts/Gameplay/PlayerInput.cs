// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public bool jumpPressed;
    [SerializeField] private FloatingJoystick joystick;

    void Update()
    {
        horizontalInput = joystick.Horizontal;
        verticalInput = joystick.Vertical;
    }

    public void OnJumpButtonPressed()
    {
        jumpPressed = true;
    }

    private void OnDisable()
    {
        horizontalInput = 0;
        verticalInput = 0;
        jumpPressed = false;
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
