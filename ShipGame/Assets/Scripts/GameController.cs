using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [SerializeField] private GameObject panelMenu;
    [SerializeField] private GameObject panelOptions;

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
}
