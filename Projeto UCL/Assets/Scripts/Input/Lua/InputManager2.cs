using UnityEngine;
using System;
using UnityEngine.InputSystem; // Necessário para InputAction


public class InputManager2
{
    private PlayerControls2 playerControls2;

    public float Movimento => playerControls2.Gameplay2.Movimento.ReadValue<float>();

    public event Action OnJump2;
    

    public InputManager2()
    {
        playerControls2 = new PlayerControls2();
        playerControls2.Gameplay2.Enable();
        playerControls2.Gameplay2.Jump2.performed += OnjumPerformed;
    }
    private void OnjumPerformed(InputAction.CallbackContext context)
    {
        OnJump2?.Invoke();
    }
}
