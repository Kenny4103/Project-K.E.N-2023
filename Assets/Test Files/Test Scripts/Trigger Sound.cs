using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameObject targetObject; // Reference to the target GameObject
    private AudioSource audioSource; // Reference to the AudioSource on the target GameObject

    void Start()
    {
        // Get the AudioSource component from the targetObject
        audioSource = targetObject.GetComponent<AudioSource>();

        // Check if an AudioSource component is found
        if (audioSource == null)
        {
            Debug.LogWarning("AudioSource component not found on the target object.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player entered the trigger zone
            Debug.Log("Player entered the trigger zone.");

            // Check if a target object and AudioSource are assigned
            if (targetObject != null && audioSource != null)
            {
                // Play the audio source
                audioSource.Play();

                // Add custom logic or event here with the targetObject
                Debug.Log("Target object is: " + targetObject.name);
            }
            else
            {
                Debug.LogWarning("Target object or AudioSource is not assigned!");
            }
        }
    }
}
