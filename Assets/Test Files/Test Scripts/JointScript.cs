using UnityEngine;

public class CarSuspension : MonoBehaviour
{
    public GameObject connectedObject; // Reference to the object you want to connect
    private bool isConnected = false;

    private void Update()
    {
        if (!isConnected)
        {
            ConnectObjects();
            isConnected = true;
        }
    }

    private void ConnectObjects()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Rigidbody connectedRigidbody = connectedObject.GetComponent<Rigidbody>();

        if (rigidbody != null && connectedRigidbody != null)
        {
            // Adjust the position of the connected object to prevent overlapping
            float yOffset = 1.0f; // Adjust the offset as needed
            connectedObject.transform.position = new Vector3(connectedObject.transform.position.x, rigidbody.transform.position.y + yOffset, connectedObject.transform.position.z);

            // Connect the objects with a fixed joint
            FixedJoint fixedJoint = connectedObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = rigidbody;
        }
    }
}

