// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyRollSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] candyRollPrefabs;
    [SerializeField] private Transform spawnPoint;

    private int currentIndex = 0;
    private List<GameObject> candyRollSpawnObj = new List<GameObject>();
    private int maxObjects = 3;
    private float interval = 3f;

    void Start()
    {
        StartCoroutine(CandyRollSpawnObjects());
    }

    IEnumerator CandyRollSpawnObjects()
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
