using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public static float choosedTime;
    public static float spawnTimeChoosed;


    public void ButtonGameSession(string gameSession)
    {
        switch(gameSession)
        {
            case "A":
            choosedTime = 60f;
            break;

            case "B":
            choosedTime = 120f;
            break;

            case "C":
            choosedTime = 180f;
            break;
        }
    }

    public void ButtonSpawnTime(string spawnTime)
    {
        switch(spawnTime)
        {
            case "D":
            spawnTimeChoosed = 5f;
            break;

            case "E":
            spawnTimeChoosed = 10f;
            break;

            case "F":
            spawnTimeChoosed = 20f;
            break;
        }
    }
}
