using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Timer;
    void Start()
    {
        ExamTimer examTimer = Timer.GetComponent<ExamTimer>();
        examTimer.StopTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
