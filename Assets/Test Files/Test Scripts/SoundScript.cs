using UnityEngine;
using UnityEngine.UI;

public class SoundDemo : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public AudioSource soundEffect;
    public Text microphoneInputText;

    private bool isMicrophoneRecording = false;

    void Start()
    {
        backgroundMusic.Play();

        if (Microphone.devices.Length > 0)
        {
            StartMicrophoneRecording();
        }
        else
        {
            Debug.LogWarning("No microphone detected.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySoundEffect();
        }

        if (isMicrophoneRecording)
        {
            float microphoneInputLevel = GetMicrophoneInputLevel();
            microphoneInputText.text = "Microphone Input Level: " + microphoneInputLevel.ToString("F2");
        }
    }

    void PlaySoundEffect()
    {
        soundEffect.Play();
    }

    void StartMicrophoneRecording()
    {
        soundEffect.clip = Microphone.Start(null, true, 10, 44100);
        soundEffect.loop = true;

        if (Microphone.IsRecording(null))
        {
            isMicrophoneRecording = true;
            soundEffect.Play();
        }
        else
        {
            Debug.LogWarning("Microphone recording failed.");
        }
    }

    float GetMicrophoneInputLevel()
    {
        float[] samples = new float[128];
        soundEffect.GetOutputData(samples, 0);
        float level = 0;

        foreach (var sample in samples)
        {
            level += Mathf.Abs(sample);
        }

        return level / samples.Length;
    }

    void OnDestroy()
    {
        if (isMicrophoneRecording)
        {
            Microphone.End(null);
        }
    }
}
