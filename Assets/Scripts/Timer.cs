using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timeRemaining;

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            // Do after time started
            timeRemaining -= Time.deltaTime;
            Debug.Log("Scenario started");
        }
        else if(timeRemaining < 0)
        {   
            // Do after time run out
            timeRemaining = 0;
            Debug.Log("Scenario ended");
            timerText.color = Color.red;
        }

        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
