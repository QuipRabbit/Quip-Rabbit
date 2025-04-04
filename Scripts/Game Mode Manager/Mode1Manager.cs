// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Mode1Manager : MonoBehaviour
{
    [SerializeField] private Canvas _canvasGameUI;
    [SerializeField] private Canvas _canvasCountdown;
    [SerializeField] private TMP_Text countdownText;
    [SerializeField] private Animator cameraStartAnimator;
    [SerializeField] private Camera cameraStartAnimation;
    [SerializeField] private AudioSource startAudioGame;
    [SerializeField] private AudioSource count321;
    [SerializeField] private AudioSource letsGo;
    [SerializeField] private AudioSource gameSound;

    void Start()
    {
        cameraStartAnimator.Play("Mode1CameraStartAnimation");
        startAudioGame.Play();
        count321.Stop();
        letsGo.Stop();
        gameSound.Stop();
        StartCoroutine(WaitCamera());
    }

    IEnumerator WaitCamera()
    {
        yield return new WaitForSeconds(4f);
        cameraStartAnimator.enabled = false;
        cameraStartAnimator.speed = 0;
        cameraStartAnimation.gameObject.SetActive(false);
        cameraStartAnimation.enabled = false;
        _canvasCountdown.gameObject.SetActive(true);
        _canvasCountdown.enabled = true;
        _canvasGameUI.gameObject.SetActive(true);
        _canvasGameUI.enabled = true;
        startAudioGame.Stop();
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        for (int i = 3; i > 0; i--)
        {
            countdownText.text = i.ToString();
            count321.Play();
            yield return new WaitForSeconds(1f);
        }
        countdownText.text = "LET'S GO!";
        letsGo.Play();
        yield return new WaitForSeconds(1f);
        gameSound.Play();
        _canvasCountdown.gameObject.SetActive(false);
        _canvasCountdown.enabled = false;
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
