// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    [SerializeField] private Transform cannonObject;
    private float moveDistance = 7.5f;
    private float moveSpeed = 5f;
    private float waitTime = 0.01f;

    private Vector3 startPositionCannonObject;
    private Vector3 targetPositionCannonObject;
    private bool movingHorizontal = true;

    void Start()
    {
        startPositionCannonObject = cannonObject.position;
        targetPositionCannonObject = startPositionCannonObject + new Vector3(-moveDistance, 0, 0);

        StartCoroutine(MoveCannonObject());
    }

    IEnumerator MoveCannonObject()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
