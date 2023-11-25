using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinkerCell : MonoBehaviour
{

    public GameObject Tink_Cell;
    bool phoneUp;
    // Update is called once per frame
    private void Start()
    {
        Tink_Cell.GetComponent<Animator>().Play("Tink_Start");
        phoneUp = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Tink_Cell.GetComponent<Animator>().Play("Tink_Up");
            phoneUp = true;
        }

        else if(Input.GetKeyDown(KeyCode.Q) && phoneUp == true)
        {
            Tink_Cell.GetComponent<Animator>().Play("Tink_Down");
            phoneUp = false;
        }
    }
}
