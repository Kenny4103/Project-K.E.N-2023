using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 45.0f; // Degrees per second
    public Vector3 rotationAxis = Vector3.up; // Axis of rotation

    void Update()
    {
        // Rotate the object around the specified axis using quaternions
        Quaternion rotation = Quaternion.Euler(rotationAxis * rotationSpeed * Time.deltaTime);
        transform.rotation *= rotation;
    }
}

