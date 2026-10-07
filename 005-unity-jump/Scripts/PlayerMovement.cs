using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Editor Fields
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;

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
        // This is the old code from the Move example
        // playerRigidbody2D.linearVelocity = moveInput * moveSpeed;

        // We need to preserve the Y value from jumping
        playerRigidbody2D.linearVelocity = new Vector2(moveInput.x * moveSpeed, playerRigidbody2D.linearVelocity.y);

    }

    // External Functions
    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log($"OnJump Called, phase, {context.phase}");

        if (context.performed)
        {
            playerRigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

}