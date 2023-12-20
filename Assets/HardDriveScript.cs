using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardDriveScript : MonoBehaviour
{
    public float interactionDistance;
    //public GameObject intText;

    //public Image crosshair = null;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            if ((hit.collider.gameObject.tag == "HardDrive") || (hit.collider.CompareTag("HardDrive")))
            {
                GameObject FBX = hit.collider.transform.root.gameObject;
                //intText.SetActive(true);
                //crosshair.color = Color.red;

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Destroy(FBX);
                }
            }

            else
            {
                //intText.SetActive(false);
                //crosshair.color = Color.white;
            }
        }

        else
        {
            //intText.SetActive(false);
            //crosshair.color = Color.white;
        }
    }
}
