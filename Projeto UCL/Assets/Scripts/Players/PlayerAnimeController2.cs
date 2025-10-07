using UnityEngine;

public class PlayerAnimeController2 : MonoBehaviour
{
    private Animator animator;
    private TerraCheck terraCheck2;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        terraCheck2 = GetComponent<TerraCheck>();
    }

    private void Update()
    {
        bool isMoving2 = GameManager2.Instance2.InputManager2.Movimento != 0;
        animator.SetBool("isMoving2", isMoving2);
        animator.SetBool("isJump2", !terraCheck2.IsGrounded());
    }
}
