using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHint : MonoBehaviour
{
    public float speed = 0.1f;
    public Transform target;

    private bool isTriger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void setTriger()
    {
        isTriger = true;
    }
    
    void Update() {
        if (isTriger)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
