using System;
using UnityEngine.InputSystem; // Necessário para InputAction

public class InputManager
{
    private PlayerControls playerControls;

    public float Movement => playerControls.Gameplay.Movement.ReadValue<float>();

    public event Action OnJump;

    public InputManager()
    {
        playerControls = new PlayerControls();
        playerControls.Gameplay.Enable();

        // Certifique-se que Jump existe no action map Gameplay
        playerControls.Gameplay.Jump.performed += OnJumpPerformed;
    }

    private void OnJumpPerformed(InputAction.CallbackContext context)
    {
        OnJump?.Invoke();
    }
}