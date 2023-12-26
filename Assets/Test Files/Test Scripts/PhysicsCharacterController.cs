using UnityEngine;

public class ObjectPhysics : MonoBehaviour
{
    private Rigidbody rb;
    public float forceMultiplier = 5.0f; // Adjust the force applied based on this multiplier

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ApplyInitialForce();
    }

    void ApplyInitialForce()
    {
        rb.AddForce(Vector3.up * forceMultiplier, ForceMode.Impulse); // Apply an initial upward impulse force
    }

    void Update()
    {
        HandlePlayerInput();
    }

    void HandlePlayerInput()
    {
        // Example: Apply force based on player input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 inputForce = new Vector3(horizontalInput, 0.0f, verticalInput);
        rb.AddForce(inputForce * forceMultiplier);
    }
}
