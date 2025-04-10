// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class BreadRoll : MonoBehaviour
{
    [SerializeField] private Transform[] breadRollLeftObjects;
    [SerializeField] private Transform breadRollRightObject;
    private float moveDistance = 5.85f;
    private float moveSpeed = 3f;
    private float waitTime = 0.01f;

    private Vector3[] startPositionsbreadRollLeftObjects;
    private Vector3[] targetPositionsbreadRollLeftObjects;
    private Vector3 startPositionsbreadRollRightObject;
    private Vector3 targetPositionsbreadRollRightObject;
    private bool movingLeft = true;
    private bool movingRight = true;

    void Start()
    {
        if (breadRollLeftObjects.Length == 0) return;

        startPositionsbreadRollLeftObjects = new Vector3[breadRollLeftObjects.Length];
        targetPositionsbreadRollLeftObjects = new Vector3[breadRollLeftObjects.Length];

        for (int i = 0; i < breadRollLeftObjects.Length; i++)
        {
            startPositionsbreadRollLeftObjects[i] = breadRollLeftObjects[i].position;
            targetPositionsbreadRollLeftObjects[i] = startPositionsbreadRollLeftObjects[i] + new Vector3(-moveDistance, 0, 0);
        }

        startPositionsbreadRollRightObject = breadRollRightObject.position;
        targetPositionsbreadRollRightObject = startPositionsbreadRollRightObject + new Vector3(moveDistance, 0, 0);

        StartCoroutine(MoveBreadRollLeftObjects());
        StartCoroutine(MoveBreadRollRightObjects());
    }

    IEnumerator MoveBreadRollLeftObjects()
    {
        
    }

    IEnumerator MoveBreadRollRightObjects()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
