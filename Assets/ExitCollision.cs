using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorCollision : MonoBehaviour
{
    // No need for Start and Update methods if they are empty

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        string nextSceneName = "Floor_1";
        SceneManager.LoadScene(nextSceneName);
    }
}
