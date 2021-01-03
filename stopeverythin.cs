using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;


public class stopeverythin : MonoBehaviour
{
    GameObject player;


    void Start()
    {
    
    }
    public void durdur()
    {
        

        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.m_cursorIsLocked=false;
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.tutorial = true;
        player.GetComponent<RigidbodyFirstPersonController>().movementSettings.tutoiral = true;
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.XSensitivity = 0;
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.YSensitivity = 0;
        player.GetComponent<Rigidbody>().isKinematic = true;
    }
    public void baslat()
    {
       
            player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<RigidbodyFirstPersonController>().mouseLook.m_cursorIsLocked = true;
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.tutorial = false;
        player.GetComponent<RigidbodyFirstPersonController>().movementSettings.tutoiral = false;
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.XSensitivity = 2;
        player.GetComponent<RigidbodyFirstPersonController>().mouseLook.YSensitivity = 2;
        player.GetComponent<Rigidbody>().isKinematic = false;
        
    }
}
