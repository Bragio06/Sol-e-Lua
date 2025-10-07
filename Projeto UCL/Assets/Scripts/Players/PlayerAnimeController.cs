using UnityEngine;

public class PlayerAnimeController : MonoBehaviour
{
    private Animator animator;
    private TerraCheck terraCheck;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        terraCheck = GetComponent<TerraCheck>();
    }

    private void Update()
    {
        bool isMoving = GameManager.Instance.InputManager.Movement != 0;
        animator.SetBool("isMoving", isMoving);
        animator.SetBool("isJump", !terraCheck.IsGrounded());
    }
}
