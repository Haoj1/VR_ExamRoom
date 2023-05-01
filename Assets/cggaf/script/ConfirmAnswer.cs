using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmAnswer : MonoBehaviour
{
    public GameObject CorrectAnswer;
    
    public  AudioSource success;
    public  AudioSource fail;
    
    public GameObject successUI;
    public GameObject failUI;
    // Start is called before the first frame update
    
    private void Start()
    {
        
    }
    public void Confirm()
    {
        GetScoreOnSelect otherScript = CorrectAnswer.GetComponent<GetScoreOnSelect>();
        if (otherScript.selected == true)
        {
            //success.Play();
            successUI.SetActive(true);
        }
        else
        {
            //fail.Play();
            failUI.SetActive(true);
        }
    }
}
