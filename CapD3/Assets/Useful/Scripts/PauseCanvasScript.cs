using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    [SerializeField] private GameObject Btncanvas;
    [SerializeField] private GameObject pausecanvas;

    public void ScoreboardBtnpressed()
    {
        SceneManager.LoadScene("Scoreboard");
        Time.timeScale = 1;
    }
    public void whenuserdead()
    {
        pausecanvas.SetActive(true);
        childrens[2].SetActive(true);
        childrens[4].SetActive(true);
        childrens[5].SetActive(false);
    }
    public void whenResumeBtnpressed()
    {
        Btncanvas.SetActive(true);
        pausecanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
