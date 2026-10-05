using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public void OnPause(InputAction.CallbackContext context)
    {
        // NOTE: In the video we don't check the context, however, we should
        // check if the action is complete or `context.performed` to ensure it always
        // works as expected.
        if (context.performed)
        {
            gameManager.TogglePause();
        }

    }
}
