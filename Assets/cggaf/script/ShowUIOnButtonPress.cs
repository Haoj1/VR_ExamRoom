using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ShowUIOnButtonPress : MonoBehaviour
{
    public GameObject UI;

    void Update()
    {
        if (Input.GetButtonDown("XR_Menu"))
        {
            UI.SetActive(!UI.activeSelf);
        }
    }
}