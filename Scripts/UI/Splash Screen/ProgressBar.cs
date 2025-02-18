// After the Quip Rabbit token pre-sale is successful and the tokens are sold out. We will update the latest and complete code, thank you.

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider _progressBarSlider;
    [SerializeField] private float _valueFillSpeed = 0.5f;
    private float _valueTargetProgress;

    private void Awake()
    {
        _progressBarSlider = gameObject.GetComponent<Slider>();
    }

    void Start()
    {
        IncrementProgressBar(1f);
    }

    void Update()
    {
        if (_progressBarSlider.value < _valueTargetProgress)
        {
            _progressBarSlider.value += _valueFillSpeed * Time.deltaTime;
        }
    }

    // Progress bar
    public void IncrementProgressBar(float _newProgressBar)
    {
        _valueTargetProgress = _progressBarSlider.value + _newProgressBar;
    }
}

// After the Quip Rabbit token pre-sale is successful and the tokens are sold out. We will update the latest and complete code, thank you.
