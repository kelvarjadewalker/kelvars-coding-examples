using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    
    public void OnPause(InputAction.CallbackContext context)
    {
        gameManager.TogglePause();
    }
}
