using UnityEngine;

public class PlayerLua : MonoBehaviour
{
    private InputManager2 inputManager2;
    [SerializeField] private float moveSpeed2 = 5;
    [SerializeField] private float jumpForce = 6;

    private Rigidbody2D rigidboby2;
    private TerraCheck terraCheck2;

    private void Awake()
    {
        rigidboby2 = GetComponent<Rigidbody2D>();
        terraCheck2 = GetComponent<TerraCheck>();
    }


    private void Start()
    {
        GameManager2.Instance2.InputManager2.OnJump2 += HandleJump;

    }

    private void Update()
    {
        float moveDirection2 = GameManager2.Instance2.InputManager2.Movimento;
        transform.Translate(moveDirection2 * Time.deltaTime * moveSpeed2, 0, 0);
        if (moveDirection2 < 0)
        {
            transform.localScale = new Vector3(-2, 2, 1);
        }
        else if (moveDirection2 > 0)
        {
            transform.localScale = new Vector3(2,2, 1);
        }


    }
    private void HandleJump()
    {
        if (terraCheck2.IsGrounded() == false) return;
        rigidboby2.linearVelocity += Vector2.up * jumpForce;
    }
}
