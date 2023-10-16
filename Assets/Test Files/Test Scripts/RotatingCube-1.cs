using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotatingCube : MonoBehaviour
{
    public float rotationSpeed = 20.0f; // Adjust this to control the rotation speed.
    public float colorChangeSpeed = 0.25f; // Adjust this to control the color change speed.
    public Color startColor = Color.green;
    public Color endColor = Color.blue;

    private float t = 0.0f;
    private Renderer cubeRenderer;

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.material.color = startColor;
    }

    private void Update()
    {
        // Rotate the cube
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Gradually change the color
        t += colorChangeSpeed * Time.deltaTime;
        cubeRenderer.material.color = Color.Lerp(startColor, endColor, t);

        // Reset the color change when it reaches the end color
        if (t >= 1.0f)
        {
            t = 0.0f;
            var tempColor = startColor;
            startColor = endColor;
            endColor = tempColor;
        }
    }
}
