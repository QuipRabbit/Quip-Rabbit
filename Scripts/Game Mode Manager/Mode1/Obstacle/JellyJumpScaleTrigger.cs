// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using UnityEngine;

public class JellyJumpScaleTrigger : MonoBehaviour
{
    private Transform jellyJumpToScale;
    private float scaleSpeed = 400f;
    private float bounceHeight = 5f;
    private float bounceDuration = 0.35f;
    private bool isBouncing = false;

    private Vector3 startScaleJellyJump = new Vector3(100f, 100f, 100f);
    private Vector3 endScaleJellyJump = new Vector3(150f, 150f, 150f);

    private void Awake()
    {
        jellyJumpToScale = transform.parent.GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isBouncing && other.CompareTag("Player") || other.CompareTag("Bot"))
        {
            StartCoroutine(JellyJumpStartBigScale(other));
            StartCoroutine(BounceUp(other.transform));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Bot"))
        {
            StartCoroutine(JellyJumpEndLowScale());
            isBouncing = false;
        }
    }

    IEnumerator JellyJumpStartBigScale(Collider other)
    {
        
    }

    IEnumerator JellyJumpEndLowScale()
    {
        
    }

    IEnumerator BounceUp(Transform target)
    {
        
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
