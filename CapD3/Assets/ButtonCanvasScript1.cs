using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCanvasScript1 : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    [SerializeField] private GameObject Btncanvas;
    [SerializeField] private GameObject pausecanvas;
    // Start is called before the first frame update

    public void whenuserdead()
    {
        Btncanvas.SetActive(false);
        //childrens[0].SetActive(false);
        //childrens[1].SetActive(false);
    }

    public void whenpauseBtnpressed()
    {
        pausecanvas.SetActive(true);
        Btncanvas.SetActive(false);
        Time.timeScale = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
