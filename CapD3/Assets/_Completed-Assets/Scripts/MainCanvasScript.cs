using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;
    [SerializeField] private GameObject StageSelectCanvas;
    public void StartBtnPressed()
    {
        StageSelectCanvas.SetActive(true);
        MainCanvasDisappearing();
    }

    public void MainCanvasDisappearing()
    {
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
