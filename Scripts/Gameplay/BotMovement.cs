// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.

using System.Collections;
using System.Linq;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    [SerializeField] private BoxCollider botBoxCollider;
    [SerializeField] private GameObject bot;
    [SerializeField] private RuntimeAnimatorController animController;
    [SerializeField] private RuntimeAnimatorController animControllerIdle;
    private GameObject finish3DPlane;
    private Mode1BotJumpBoxCollider[] boxColliderScripts;
    private FinishManager finishManagerScript;
    private Vector3 movementVelocity;
    private float moveSpeed = 4f;
    private float gravity = -1f;
    private Animator animatorIdle;
    private Animator animator;
    private float jumpForce = 15f;
    private float verticalVelocity;
    private float targetCenterY;
    private float speed = 0.06f;
    private bool isMoveBot;

    private void Awake()
    {
        animatorIdle = GetComponent<Animator>();
        animator = GetComponent<Animator>();
        boxColliderScripts = FindObjectsByType<Mode1BotJumpBoxCollider>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        finishManagerScript = FindObjectsByType<FinishManager>(FindObjectsInactive.Include, FindObjectsSortMode.None).FirstOrDefault();
        finish3DPlane = GameObject.FindWithTag("FinishTarget");
    }

    void Update()
    {
        
    }

}

// After Quip Rabbit token pre-sale (ICO) is successful and reaches the hard cap. We will update the latest and complete code, thank you very much.
