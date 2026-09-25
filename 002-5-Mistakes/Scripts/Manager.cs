using UnityEngine;

public class Manager : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // 3. Calling `GetComponent()` Repeatedly
    private void Update()
    {
        // In this case let's assume velocity is a Vector2 variable we have defined elsewhere in the script
        var velocity = new Vector2(1, 2);  // This is just an example

        // The problem is repeatedly looking up the same component, especially in Update,
        // when you could retrieve it once and keep the reference.
        playerRigidbody.linearVelocity = velocity;

    }
}
