using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinkerCell : MonoBehaviour
{

    public GameObject Tink_Cell;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Tink_Cell.GetComponent<Animator>().Play("Tink_Up");
        }
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Tink_Cell.GetComponent<Animator>().Play("Tink_Down");
        }
    }
}
