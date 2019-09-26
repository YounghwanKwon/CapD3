using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] maps;
    [SerializeField] private GameObject[] canvas;
    [SerializeField] private GameObject[] tanks;
    [SerializeField] private GameObject[] turretsset;
    public void Stage1BtnPressed()
    {
        canvas[1].SetActive(true);
        canvas[2].SetActive(true);
        canvas[3].SetActive(true);
        maps[0].SetActive(true);
        tanks[0].SetActive(true);

        StageSelectCanvasDisappearing();
    }

    public void BackToMainBtnPressed()
    {
        canvas[0].SetActive(true);

        StageSelectCanvasDisappearing();
    }
    
    public void StageSelectCanvasDisappearing()
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
