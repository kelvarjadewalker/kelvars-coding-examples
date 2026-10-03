using UnityEngine;

public class OldInputMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);
    }
}