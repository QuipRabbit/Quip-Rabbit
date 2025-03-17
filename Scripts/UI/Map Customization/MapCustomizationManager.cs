// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using UnityEngine;
using UnityEngine.SceneManagement;

public class MapCustomizationManager : MonoBehaviour
{
    [SerializeField] private Canvas _canvasStage;
    [SerializeField] private Canvas _canvasDecoration;
    [SerializeField] private Canvas _canvasObstacle;
    [SerializeField] private Canvas _canvasShape;
    [SerializeField] private Canvas _canvasToehold;
    public Canvas _canvasEditTransform;
    [SerializeField] private Canvas _canvasPositionEditTransform;
    [SerializeField] private GameObject positionHorizontal;
    [SerializeField] private GameObject positionVertical;
    [SerializeField] private Canvas _canvasRotationEditTransform;
    [SerializeField] private Canvas _canvasDeleteEditTransform;

    public static MapCustomizationManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void StageToggle_onClick()
    {
        _canvasStage.gameObject.SetActive(true);
        _canvasStage.enabled = true;
        _canvasDecoration.gameObject.SetActive(false);
        _canvasDecoration.enabled = false;
        _canvasObstacle.gameObject.SetActive(false);
        _canvasObstacle.enabled = false;
        _canvasShape.gameObject.SetActive(false);
        _canvasShape.enabled = false;
        _canvasToehold.gameObject.SetActive(false);
        _canvasToehold.enabled = false;
    }

    public void DecorationToggle_onClick()
    {
        _canvasStage.gameObject.SetActive(false);
        _canvasStage.enabled = false;
        _canvasDecoration.gameObject.SetActive(true);
        _canvasDecoration.enabled = true;
        _canvasObstacle.gameObject.SetActive(false);
        _canvasObstacle.enabled = false;
        _canvasShape.gameObject.SetActive(false);
        _canvasShape.enabled = false;
        _canvasToehold.gameObject.SetActive(false);
        _canvasToehold.enabled = false;
    }

    public void ObstacleToggle_onClick()
    {
        _canvasStage.gameObject.SetActive(false);
        _canvasStage.enabled = false;
        _canvasDecoration.gameObject.SetActive(false);
        _canvasDecoration.enabled = false;
        _canvasObstacle.gameObject.SetActive(true);
        _canvasObstacle.enabled = true;
        _canvasShape.gameObject.SetActive(false);
        _canvasShape.enabled = false;
        _canvasToehold.gameObject.SetActive(false);
        _canvasToehold.enabled = false;
    }

    public void ShapeToggle_onClick()
    {
        _canvasStage.gameObject.SetActive(false);
        _canvasStage.enabled = false;
        _canvasDecoration.gameObject.SetActive(false);
        _canvasDecoration.enabled = false;
        _canvasObstacle.gameObject.SetActive(false);
        _canvasObstacle.enabled = false;
        _canvasShape.gameObject.SetActive(true);
        _canvasShape.enabled = true;
        _canvasToehold.gameObject.SetActive(false);
        _canvasToehold.enabled = false;
    }

    public void ToeholdToggle_onClick()
    {
        _canvasStage.gameObject.SetActive(false);
        _canvasStage.enabled = false;
        _canvasDecoration.gameObject.SetActive(false);
        _canvasDecoration.enabled = false;
        _canvasObstacle.gameObject.SetActive(false);
        _canvasObstacle.enabled = false;
        _canvasShape.gameObject.SetActive(false);
        _canvasShape.enabled = false;
        _canvasToehold.gameObject.SetActive(true);
        _canvasToehold.enabled = true;
    }

    public void ShowPositionHorizontalEditTransform()
    {
        _canvasPositionEditTransform.gameObject.SetActive(true);
        _canvasPositionEditTransform.enabled = true;
        _canvasPositionEditTransform.gameObject.SetActive(true);
        _canvasPositionEditTransform.enabled = true;
        positionHorizontal.SetActive(true);
        positionVertical.SetActive(false);
        _canvasRotationEditTransform.gameObject.SetActive(false);
        _canvasRotationEditTransform.enabled = false;
        _canvasDeleteEditTransform.gameObject.SetActive(false);
        _canvasDeleteEditTransform.enabled = false;
    }

    public void ShowPositionVerticalEditTransform()
    {
        _canvasPositionEditTransform.gameObject.SetActive(true);
        _canvasPositionEditTransform.enabled = true;
        _canvasPositionEditTransform.gameObject.SetActive(true);
        _canvasPositionEditTransform.enabled = true;
        positionHorizontal.SetActive(false);
        positionVertical.SetActive(true);
        _canvasRotationEditTransform.gameObject.SetActive(false);
        _canvasRotationEditTransform.enabled = false;
        _canvasDeleteEditTransform.gameObject.SetActive(false);
        _canvasDeleteEditTransform.enabled = false;
    }

    public void ShowRotationEditTransform()
    {
        _canvasPositionEditTransform.gameObject.SetActive(true);
        _canvasPositionEditTransform.enabled = true;
        _canvasPositionEditTransform.gameObject.SetActive(false);
        _canvasPositionEditTransform.enabled = false;
        positionHorizontal.SetActive(false);
        positionVertical.SetActive(false);
        _canvasRotationEditTransform.gameObject.SetActive(true);
        _canvasRotationEditTransform.enabled = true;
        _canvasDeleteEditTransform.gameObject.SetActive(false);
        _canvasDeleteEditTransform.enabled = false;
    }

    public void ShowDeleteEditTransform()
    {
        _canvasPositionEditTransform.gameObject.SetActive(true);
        _canvasPositionEditTransform.enabled = true;
        _canvasPositionEditTransform.gameObject.SetActive(false);
        _canvasPositionEditTransform.enabled = false;
        positionHorizontal.SetActive(false);
        positionVertical.SetActive(false);
        _canvasRotationEditTransform.gameObject.SetActive(false);
        _canvasRotationEditTransform.enabled = false;
        _canvasDeleteEditTransform.gameObject.SetActive(true);
        _canvasDeleteEditTransform.enabled = true;
    }

    public void HideEditTransform()
    {
        _canvasEditTransform.gameObject.SetActive(false);
        _canvasEditTransform.enabled = false;
    }

    public void HideAllEditTransform()
    {
        _canvasPositionEditTransform.gameObject.SetActive(false);
        _canvasPositionEditTransform.enabled = false;
        _canvasPositionEditTransform.gameObject.SetActive(false);
        _canvasPositionEditTransform.enabled = false;
        positionHorizontal.SetActive(false);
        positionVertical.SetActive(false);
        _canvasRotationEditTransform.gameObject.SetActive(false);
        _canvasRotationEditTransform.enabled = false;
        _canvasDeleteEditTransform.gameObject.SetActive(false);
        _canvasDeleteEditTransform.enabled = false;
    }

    public void ExitMapCustomization()
    {
        SceneManager.LoadScene("MenuScene");
    }
}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
