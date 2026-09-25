using UnityEngine;

public class Player : MonoBehaviour
{
    // ## 1. Comparing Tags With `==`
    private void OnTriggerEnter2D(Collider2D other)
    {
        // You will often see code like this:
        if (gameObject.tag == "Player")
        {
            Debug.Log("Hey, you hit me!");
        }

        // This works, but Unity provides a method specifically for checking a GameObject's tag:
        // https://docs.unity3d.com/ScriptReference/GameObject.CompareTag.html
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("Hey, you hit me!");
        }

    }

    public void TakeDamage(int damage)
    {
        Debug.Log($"You took {damage} damage!");
    }
}
