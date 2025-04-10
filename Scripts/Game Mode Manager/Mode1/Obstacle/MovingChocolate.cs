// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using UnityEngine;
using System.Collections;

public class MovingChocolate : MonoBehaviour
{
    [SerializeField] private Transform[] topChocolatesGroup;
    [SerializeField] private Transform[] bottomChocolatesGroup;
    private float moveDistance = 1f;
    private float moveSpeed = 3f;
    private float waitTime = 1f;

    private Vector3[] topChocolatesGroupStartPositions;
    private Vector3[] topChocolatesGroupTargetPositions;
    private Vector3[] bottomChocolatesGroupStartPositions;
    private Vector3[] bottomChocolatesGroupTargetPositions;
    private bool movingBottom = true;
    private bool movingUp = true;

    void Start()
    {
        topChocolatesGroupStartPositions = new Vector3[topChocolatesGroup.Length];
        topChocolatesGroupTargetPositions = new Vector3[topChocolatesGroup.Length];

        for (int i = 0; i < topChocolatesGroup.Length; i++)
        {
            topChocolatesGroupStartPositions[i] = topChocolatesGroup[i].position;
            topChocolatesGroupTargetPositions[i] = topChocolatesGroupStartPositions[i] - new Vector3(0, moveDistance, 0);
        }

        bottomChocolatesGroupStartPositions = new Vector3[bottomChocolatesGroup.Length];
        bottomChocolatesGroupTargetPositions = new Vector3[bottomChocolatesGroup.Length];

        for (int i = 0; i < bottomChocolatesGroup.Length; i++)
        {
            bottomChocolatesGroupStartPositions[i] = bottomChocolatesGroup[i].position;
            bottomChocolatesGroupTargetPositions[i] = bottomChocolatesGroupStartPositions[i] - new Vector3(0, -moveDistance, 0);
        }

        StartCoroutine(MoveTopChocolatesGroup());
        StartCoroutine(MoveBottomChocolatesGroup());
    }

    IEnumerator MoveTopChocolatesGroup()
    {
        
    }

    IEnumerator MoveBottomChocolatesGroup()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
