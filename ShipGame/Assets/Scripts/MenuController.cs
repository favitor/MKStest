using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject panelGameOver;

    void Start()
    {
        Time.timeScale = 1;
        panelGameOver.SetActive(false);
        
    }
   
    public void GameOver()
    {
        Time.timeScale = 0;
        panelGameOver.SetActive(true);
    }
}
