using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimations : MonoBehaviour
{
    public Animator animator;
    public string firstAnimation = "sit";
    public string secondAnimation = "write";

    private float animationTime = 5.0f;
    private float currentTime = 0.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play(firstAnimation);
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= animationTime)
        {
            animator.Play(secondAnimation);
        }
    }
}
