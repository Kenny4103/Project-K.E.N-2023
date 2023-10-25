using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myDoorController : MonoBehaviour
{
    private Animator doorAnim;

    private bool doorOpen = false;

    private void Awake() {
      doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation() {
      if(!doorOpen) {
        doorAnim.Play("AutoDoor_1", 0, 0f);
        doorOpen = true;
      }
      //else statement and code for door closing goes here
    }
}
