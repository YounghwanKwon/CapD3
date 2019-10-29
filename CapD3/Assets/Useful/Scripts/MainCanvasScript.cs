using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;
    public void StartBtnPressed()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void TutorialBtnPressed()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void ScoreBoardBtnPressed()
    {
        SceneManager.LoadScene("Scoreboard");
    }

    public void exitapp()
    {
        Application.Quit();
    }

    public void MainCanvasDisappearing()
    {
        this.gameObject.SetActive(false);
    }
}
