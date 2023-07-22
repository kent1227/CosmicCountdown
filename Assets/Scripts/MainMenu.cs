using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public GameObject infoPanel;
    public GameObject creditsPanel;

    public void Start()
    {
        infoPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {

    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }


}
