using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject player;

    // # 2. Finding Objects by Name
    private void Start()
    {
        // For example, your script now assumes that an object is named exactly:
        GameObject player = GameObject.Find("Player");

        // Note: This will be null if you change the spelling of the game object in the Editor!  
    }
}
