using System.Collections;using System.Collections.Generic;using UnityEngine;using StarterAssets;using UnityEngine.InputSystem;public class bounce: MonoBehaviour{    public float newJumpHeight;    float originalJumpHeight;    public GameObject thePlayer;    public StarterAssetsInputs theInput;    private void OnTriggerEnter(Collider other)    {
    

        if (other.CompareTag("Player"))        {            originalJumpHeight = thePlayer.GetComponent<FirstPersonController>().JumpHeight;            thePlayer.GetComponent<FirstPersonController>().JumpHeight = newJumpHeight;            theInput.jump = true;

        }    }    private void OnTriggerExit(Collider other)    {
        if (other.CompareTag("Player"))
        {
            thePlayer.GetComponent<FirstPersonController>().JumpHeight = originalJumpHeight;
        }    }}
