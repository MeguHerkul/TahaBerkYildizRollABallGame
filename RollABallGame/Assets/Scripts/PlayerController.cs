using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Speed variable for the ball
    public float ballSpeed = 10f;

    private Rigidbody rb;
    private float moveX;
    private float moveZ;

    void Start()
    {
        // Connecting to the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Detecting the movement inputs
    void OnMove(InputValue inputData)
    {
        Vector2 movementVector = inputData.Get<Vector2>();

        // Storing the input values
        moveX = movementVector.x;
        moveZ = movementVector.y;
    }

    void FixedUpdate()
    {
        // Creating the movement direction for the ball
        Vector3 force = new Vector3(moveX, 0.0f, moveZ);

        // Applying the force to the ball
        rb.AddForce(force * ballSpeed);
    }
}
