using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform[] points; // Array of four points to move between
    public float speed = 1f; // Speed of the object

    private int currentPoint = 0; // Current point index
    private Vector3 targetPosition; // Target position to move towards
    public Animator animator;
    void Start()
    {
        // Set initial target position to the first point
        targetPosition = points[currentPoint].position;
        animator = GetComponent<Animator>();
        // animator.Play("turn");
    }

    void Update()
    {
        // Move object towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        transform.LookAt(targetPosition,Vector3.up);

        // Check if the object has reached the target position
        if (transform.position == targetPosition)
        {
            // Update current point index
            currentPoint++;

            // Reset current point index to 0 if it exceeds the array length
            if (currentPoint >= points.Length)
            {
                currentPoint = 0;
            }
            // animator.Play("turn");
            // Set new target position to the next point
            targetPosition = points[currentPoint].position;
        }
    }
}
