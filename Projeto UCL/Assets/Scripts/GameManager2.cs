using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 Instance2;
    public InputManager2 InputManager2 { get; private set; }

    private void Awake()
    {
        if (Instance2 != null) Destroy(this.gameObject);
        Instance2 = this;

        InputManager2 = new InputManager2();
    }
}