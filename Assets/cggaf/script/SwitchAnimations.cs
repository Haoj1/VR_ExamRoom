using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimations : MonoBehaviour
{
    public GameObject[] characters;
    public string firstAnimation = "sit";
    public string secondAnimation = "write";

    void Start()
    {
        foreach (GameObject character in characters)
        {
            Animator animator = character.GetComponent<Animator>();
            animator.Play(firstAnimation);
        }
    }

    void Update()
    {
       
    }

    public void SwitchToWriting()
    {
        foreach (GameObject character in characters)
        {
            Animator animator = character.GetComponent<Animator>();
            animator.Play(secondAnimation);
        }
    }
}
