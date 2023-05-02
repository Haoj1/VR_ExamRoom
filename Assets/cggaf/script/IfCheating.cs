using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCheating : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isCheating;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsCheat()
    {
        isCheating = true;
    }
    
    public void NotCheat()
    {
        isCheating = false;
    }
}
