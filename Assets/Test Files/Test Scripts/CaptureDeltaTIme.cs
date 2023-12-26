using UnityEngine;
using UnityEngine.UI;

public class CaptureDeltaTime : MonoBehaviour
{
    public Text captureText; // Reference to a UI Text component to display captured delta time

    private float captureInterval = 5f; // Time interval for capturing delta time
    private float captureTimer = -1f;

    private void Start()
    {
        captureTimer = captureInterval;
    }

    private void Update()
    {
        captureTimer -= Time.deltaTime;
        if (captureTimer <= 0f)
        {
            // Capture delta time and display it
            UpdateCaptureText(Time.deltaTime);
            // Reset the timer for the next capture
            captureTimer = captureInterval;
        }
    }

    private void UpdateCaptureText(float deltaTime)
    {
        if (captureText != null)
        {
            captureText.text = "Captured Delta Time: " + deltaTime.ToString("F5") + " seconds";
        }
    }
}

