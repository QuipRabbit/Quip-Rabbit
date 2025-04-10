// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class CannonBallSpawn : MonoBehaviour
{
    [SerializeField] private GameObject cannonBallPrefab;
    [SerializeField] private Transform cannonBallSpawnPlace;
    private float fireCannonBallInterval;
    private GameObject currentCannonBallObject;

    void Start()
    {
        StartCoroutine(CannonBallSpawnCoroutine());
    }

    IEnumerator CannonBallSpawnCoroutine()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
