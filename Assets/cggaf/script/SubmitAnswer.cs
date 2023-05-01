using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitAnswer : MonoBehaviour
{

    public GameObject UI;
    public GameObject surface;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Pencil")
        {
            BoxCollider boxCollider = surface.GetComponent<BoxCollider>();
            UI.SetActive(true);
            //boxCollider.enabled = false;
            surface.SetActive(false);
        }
    }
}
