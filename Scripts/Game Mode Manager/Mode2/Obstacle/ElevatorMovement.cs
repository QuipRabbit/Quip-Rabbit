// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    [SerializeField] private Transform leftElevator;
    [SerializeField] private Transform rightElevator;
    private float moveDistance = 6.32f;
    private float moveSpeed = 5f;
    private float waitTime = 1f;

    private Vector3 leftElevatorStartPositions;
    private Vector3 leftElevatorTargetPositions;
    private Vector3 rightElevatorStartPositions;
    private Vector3 rightElevatorTargetPositions;
    private bool movingBottom = true;
    private bool movingUp = true;

    void Start()
    {
        leftElevatorStartPositions = leftElevator.position;
        leftElevatorTargetPositions = leftElevatorStartPositions + new Vector3(0, moveDistance, 0);

        rightElevatorStartPositions = rightElevator.position;
        rightElevatorTargetPositions = rightElevatorStartPositions + new Vector3(0, -moveDistance, 0);

        StartCoroutine(MoveTopElevator());
        StartCoroutine(MoveBottomElevator());
    }

    IEnumerator MoveTopElevator()
    {
        
    }

    IEnumerator MoveBottomElevator()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
