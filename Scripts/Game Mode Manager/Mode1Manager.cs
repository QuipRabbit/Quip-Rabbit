// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using System.Collections;
using UnityEngine;

public class Mode1Manager : MonoBehaviour
{
    [SerializeField] private Canvas _canvasGameUI;
    [SerializeField] private Animator cameraStartAnimator;
    [SerializeField] private Camera cameraStartAnimation;

    void Start()
    {
        cameraStartAnimator.Play("Mode1CameraStartAnimation");
        StartCoroutine(WaitCamera());
    }

    IEnumerator WaitCamera()
    {
        yield return new WaitForSeconds(4f);
        cameraStartAnimator.enabled = false;
        cameraStartAnimator.speed = 0;
        cameraStartAnimation.gameObject.SetActive(false);
        cameraStartAnimation.enabled = false;
        _canvasGameUI.gameObject.SetActive(true);
        _canvasGameUI.enabled = true;
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
