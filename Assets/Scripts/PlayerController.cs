using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // called just before performing any physics calculations
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(
            moveHorizontal,
            0.0f,
            moveVertical);

        rb.AddForce(movement);

    }
}
