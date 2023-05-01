using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ExamTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeLimit = 60.0f;
    public GameObject UI;
    private float timeRemaining;
    public bool timerRunning = false;
    private TextMeshProUGUI timerText;

    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timeRemaining = timeLimit;
    }

    private void Update()
    {
        if (timerRunning)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time Remaining: " + (int)timeRemaining;

            if (timeRemaining <= 0)
            {
                timerRunning = false;
                timerText.text = "Time's Up!";
                timeRemaining = timeLimit;
                if (UI.activeSelf == false)
                {
                    UI.SetActive(true);
                }
            }
        }
    }

    public void StartTimer()
    {
        timerRunning = true;
    }
    
    public void StopTimer()
    {
        timerRunning = false;
    }
}
