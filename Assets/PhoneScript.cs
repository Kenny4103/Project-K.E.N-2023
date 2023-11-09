using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneScript : MonoBehaviour
{
    public Animator phoneAnimator;

    bool phoneEnabled = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            phoneAnimator.SetBool("isUp", true);
            phoneEnabled = true;
        }
        else if(phoneEnabled == true && Input.GetKeyDown(KeyCode.Q))
        {
            phoneAnimator.SetBool("isDown", false);
            phoneEnabled = false;
        }

    }
}
