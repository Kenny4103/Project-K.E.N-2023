using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Make sure the object has a Rigidbody component
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found on this GameObject!");
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // Apply a forward force when the 'W' key is pressed.
            // Use rb.transform.forward instead of Vector3.forward
            rb.AddForce(rb.transform.forward * 10.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(rb.transform.forward * -5.0f);
        }
    }
}
