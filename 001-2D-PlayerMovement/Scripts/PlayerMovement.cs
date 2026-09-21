using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Editor Fields
    [SerializeField] private float moveSpeed = 5f;

    // Internal Fields
    private Vector2 moveInput;
    private Rigidbody2D playerRigidbody2D;

    // Unity Events
    private void Awake()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        playerRigidbody2D.linearVelocity = moveInput * moveSpeed;
    }

    // External Functions
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
