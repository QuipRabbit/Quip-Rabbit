// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class RotatingFans : MonoBehaviour
{
    [SerializeField] private Transform clockwiseFans; // Rotation left to right
    [SerializeField] private Transform[] counterClockwiseFans; // Rotation right to left
    private float rotationSpeed = 125f;

    void Start()
    {
        StartCoroutine(RotateFans());
    }

    private IEnumerator RotateFans()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
