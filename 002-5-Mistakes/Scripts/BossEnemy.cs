using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    // #5 - Assuming `GetComponent()` Can't Return `null`

    private Rigidbody2D bossRigidBody;

    private void Awake()
    {
        // Don't assume this object is actually on the game object.
        bossRigidBody = GetComponent<Rigidbody2D>();

        // Add a debug log to check if the component was found.
        if (bossRigidBody == null)
        {
            Debug.LogError("BossEnemy Rigidbody2D component not found!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // A lot of examples will make 2 checks when 1 is enough.
        if (other.gameObject.CompareTag("Player"))
        {
            var playerScript = other.gameObject.GetComponent<Player>();

            if (playerScript != null)
            {
                playerScript.TakeDamage(10);
            }
        }

        // A more efficient way to check if an object has a component.
        if (other.TryGetComponent(out Player player))
        {
            player.TakeDamage(10);
        }
    }
}
