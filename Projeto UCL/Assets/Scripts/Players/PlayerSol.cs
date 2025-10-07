using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{   
    [SerializeField] private float moveSpeed = 8;
    [SerializeField] private float jumpForce = 6;

    private Rigidbody2D rb;

    private TerraCheck terraCheck;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        terraCheck = GetComponent<TerraCheck>();
    }
    private void Start()
    {
        GameManager.Instance.InputManager.OnJump += HandleJump;  

    }

    private void Update()
    {
        float moveDirection = GameManager.Instance.InputManager.Movement;
        transform.Translate(moveDirection * Time.deltaTime * moveSpeed, 0,0);

        if (moveDirection < 0)
        {
            transform.localScale = new Vector3(-2, 2, 1);
        }
        else if(moveDirection > 0)
        {
            transform.localScale = new Vector3(2,2,1);
        }

    }
    private void HandleJump()
    {
        if(terraCheck.IsGrounded() == false) return;
        rb.linearVelocity = Vector2.up * jumpForce;
    }
}
