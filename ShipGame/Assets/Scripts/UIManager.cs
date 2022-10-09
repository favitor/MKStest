using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public TextMeshProUGUI score;


    void Start()
    {
        scoreValue = 0;
    }
    void Update()
    {
        score.text = "Score: " + scoreValue;
        
    }
}
