using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Editor Fields
    [SerializeField] private float moveSpeed = 5f;

    // Internal fields
    private Vector2 moveInput;
    private Rigidbody2D playerRigidbody;

    // Unity Events
    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity = moveInput * moveSpeed;
    }

    // External Functions
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
