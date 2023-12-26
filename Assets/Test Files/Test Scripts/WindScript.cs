using UnityEngine;

[RequireComponent(typeof(Transform))]
public class SimpleWind : MonoBehaviour
{
    public Vector3 windDirection = new Vector3(1f, 0f, 0f);
    public float windSpeed = 1.0f;
    public float windStrength = 1.0f;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        Vector3 windForce = windDirection.normalized * windSpeed * windStrength;
        transform.Translate(windForce * Time.deltaTime);
    }
}
