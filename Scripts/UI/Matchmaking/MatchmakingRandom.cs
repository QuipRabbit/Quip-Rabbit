// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchmakingRandom : MonoBehaviour
{
    [SerializeField] private TMP_Text currentPlayerText;
    private int currentNumber = 1;

    void Start()
    {
        StartCoroutine(RandomIncrease());
    }

    IEnumerator RandomIncrease()
    {
        while (true)
        {
            float randomWaitTime = Random.Range(0f, 3f);
            yield return new WaitForSeconds(randomWaitTime);
            int randomIncrease = Random.Range(0, 4);
            currentNumber += randomIncrease;
            currentNumber = Mathf.Min(currentNumber, 12);
            currentPlayerText.text = currentNumber.ToString();
            if(currentNumber == 12)
            {
                SceneManager.LoadScene(5);
            }
        }
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
