using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using DG.Tweening;
using UnityEngine.Networking;

public class MainMenu : MonoBehaviour
{
    public GameObject infoPanel;
    public GameObject creditsPanel;
    public GameObject controlPanel;
    public Image black;

    void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManagerOnGameStateChanged;
    }

    private void GameManagerOnGameStateChanged(GameState state)
    {
        if (state == GameState.Menu)
        {
            Debug.Log("state is menu");
            black.DOFade(0, 1.5f).SetDelay(1f).SetEase(Ease.Linear).OnComplete(DestroyBlack);

        }
    }

    private void DestroyBlack()
    {
        black.gameObject.SetActive(false);
    }

    void Start()
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
        DOTween.KillAll(true);
        SceneManager.LoadScene("Spaceship");
    }

    public void OpenPanel(GameObject panel)
    {
        RectTransform t = panel.GetComponent<RectTransform>();
        t.localScale = new Vector3(0f, 0.1f, 1f);
        panel.SetActive(true);
        t.DOScaleX(1.0f, 0.4f).OnComplete(() => t.DOScaleY(1.0f, 0.3f));

    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }


}
