using UnityEngine;
public class KeyPressVisibilityToggle : MonoBehaviour
{
    public GameObject targetObject;
    private bool isVisible = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            isVisible = !isVisible;
            targetObject.SetActive(isVisible);
        }
    }
}