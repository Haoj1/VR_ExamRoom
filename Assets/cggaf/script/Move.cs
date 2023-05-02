using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform[] points; // Array of four points to move between
    public float speed = 1f; // Speed of the object
    public GameObject targetObject;
    public GameObject isCheating;
    public GameObject UIFail;
    public float distanceThreshold = 1.0f;
    public bool isWithinDistance;
    
    public GameObject camera;
    private int currentPoint = 0; // Current point index
    private Vector3 targetPosition; // Target position to move towards
    public Animator animator;
    private bool isDetected;
    void Start()
    {   
        // Set initial target position to the first point
        targetPosition = points[currentPoint].position;
        animator = GetComponent<Animator>();
        // animator.Play("turn");
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetObject.transform.position);
        if (distance <= distanceThreshold)
        {
            isWithinDistance = true;
        }
        else
        {
            isWithinDistance = false;
        }

        IfCheating ifCheating = isCheating.GetComponent<IfCheating>();
        if (ifCheating.isCheating && isWithinDistance)
        {
            isDetected = true;
        }

        if (camera != null)
        {
            Transform cameraTransform = camera.GetComponent<Transform>();
        }
        
        
        // Move object towards the target position
        if (!isDetected)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            transform.LookAt(targetPosition,Vector3.up);
        }
        else
        {
            
            
            transform.LookAt(targetObject.transform);
            animator.enabled = false;
            UIFail.SetActive(true);
        }
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
