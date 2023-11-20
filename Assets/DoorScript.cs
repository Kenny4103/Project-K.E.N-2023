using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public float interactionDistance;
    public GameObject intText;
    public string doorOpenAnimName, doorCloseAnimName;

    public Image crosshair = null;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            if ((hit.collider.gameObject.tag == "Door") || (hit.collider.CompareTag("Door")))
            {
                GameObject doorParent = hit.collider.transform.root.gameObject;
                Animator doorAnim = doorParent.GetComponent<Animator>();
                intText.SetActive(true);
                crosshair.color = Color.red;

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    if (doorAnim.GetCurrentAnimatorStateInfo(0).IsName(doorOpenAnimName))
                    {
                        doorAnim.ResetTrigger("Open");
                        doorAnim.SetTrigger("Close");
                    }

                    if (doorAnim.GetCurrentAnimatorStateInfo(0).IsName(doorCloseAnimName))
                    {
                        doorAnim.ResetTrigger("Close");
                        doorAnim.SetTrigger("Open");
                    }
                }
            }

            else
            {
                intText.SetActive(false);
                crosshair.color = Color.white;
            }
        }

        else
        {
            intText.SetActive(false);
            crosshair.color = Color.white;
        }
    }
}
