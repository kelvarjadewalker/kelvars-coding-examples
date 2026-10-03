using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    private Vector2 moveInput;
    
    private void Update()
    {
        transform.Translate(moveInput * speed * Time.deltaTime);
    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
