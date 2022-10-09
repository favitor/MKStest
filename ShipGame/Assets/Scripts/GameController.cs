using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [SerializeField] private GameObject panelMenu;
    [SerializeField] private GameObject panelOptions;
    [SerializeField] private GameObject panelGameOver;

    void Start()
    {
        Time.timeScale = 1;
        panelGameOver.SetActive(false);
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");

    }

    public void MenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void OpenOptions()
    {
        panelMenu.SetActive(false);
        panelOptions.SetActive(true);
    }

    public void CloseOptions()
    {
        panelOptions.SetActive(false);
        panelMenu.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        panelGameOver.SetActive(true);
    }
}
