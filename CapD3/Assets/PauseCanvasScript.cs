using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    [SerializeField] private GameObject Btncanvas;
    [SerializeField] private GameObject pausecanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
    public void checkstage(int number)
    {

    }
}
