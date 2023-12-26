using UnityEngine;
using UnityEngine.UI;  // Import the UI namespace
using System.Collections;

public class FadeInFadeOut : MonoBehaviour
{
    // Duration of the fade in seconds
    public float fadeDuration = 2.0f;
    private float currentAlpha = 0.0f;
    private bool isFadingIn = true;

    // New field to reference the fade image (UI Image)
    public Image fadeImage;

    private void Start()
    {
        // If fadeImage is not set, try to get the Image component of the GameObject
        if (fadeImage == null)
            fadeImage = GetComponent<Image>();

        // Start the fading coroutine
        StartCoroutine(Fade());
    }

    private IEnumerator Fade()
    {
        // Get the initial color of the sprite
        Color startColor = fadeImage.color;
        // Create a copy of the start color
        Color endColor = startColor;
        // Set the alpha component of endColor based on fading direction
        endColor.a = isFadingIn ? 1.0f : 0.0f;
        // Record the starting time of the fade operation
        float startTime = Time.time;

        // Continue fading while alpha is within the target range
        while (currentAlpha < 1.0f && currentAlpha > 0.0f)
        {
            // Calculate the elapsed time
            float elapsedTime = Time.time - startTime;
            // Calculate the current alpha value using linear interpolation
            currentAlpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            // Set the sprite color based on the current alpha value
            fadeImage.color = Color.Lerp(startColor, endColor, currentAlpha);
            // Yield control to Unity’s update loop
            yield return null;
        }

        // Ensure that the final alpha value is exactly 1 or 0
        fadeImage.color = endColor;
    }

    // Method to start the fade in process
    public void StartFadeIn()
    {
        if (!isFadingIn)
        {
            isFadingIn = true;
            StartCoroutine(Fade());
        }
    }

    // Method to start the fade out process
    public void StartFadeOut()
    {
        if (isFadingIn)
        {
            isFadingIn = false;
            StartCoroutine(Fade());
        }
    }
}
