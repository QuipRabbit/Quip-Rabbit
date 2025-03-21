// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomModeSelection : MonoBehaviour
{
    public static int previousSceneID = -1;
    [SerializeField] private Canvas _canvasWait;
    [SerializeField] private Image[] modeActiveImages;
    [SerializeField] private Image[] selectedImages;
    private float modeActiveImageDisplayTime = 0.5f;
    private int totalLoops = 3;
    private int finalSceneID;
    private int round = 1;
    private bool isCoroutineRunning = false;

    public static RandomModeSelection instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    

}    

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.    
