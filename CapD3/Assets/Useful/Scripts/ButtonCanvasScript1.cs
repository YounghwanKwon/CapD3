using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCanvasScript1 : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    [SerializeField] private GameObject Btncanvas;
    [SerializeField] private GameObject pausecanvas;

    public void whenuserdead()
    {
        Btncanvas.SetActive(false);
    }

    public void whenpauseBtnpressed()
    {
        pausecanvas.SetActive(true);
        Btncanvas.SetActive(false);
        Time.timeScale = 0;
    }
}
