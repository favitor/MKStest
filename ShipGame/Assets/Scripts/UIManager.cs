using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public float currentTime = 0f;
    public float startTime = 90f;
    public TextMeshProUGUI score;
    public TextMeshProUGUI timerText;
    public GameController other;


    void Start()
    {
        scoreValue = 0;
        currentTime = startTime;
    }
    void Update()
    {
        score.text = "Score: " + scoreValue;

        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("00:00");

        if(currentTime <= 0)
        {
            other.GameOver();
        }

        DisplayTime(currentTime);
        
    }


    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
