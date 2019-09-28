using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] maps;
    [SerializeField] private GameObject[] canvas;
    [SerializeField] private GameObject[] tanks;
    [SerializeField] private GameObject[] turretsset;
    public void Stage1BtnPressed()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2BtnPressed()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void Canvasturnon()
    {
        canvas[1].SetActive(true);
        canvas[2].SetActive(true);
        canvas[3].SetActive(true);
    }
    public void BackToMainBtnPressed()
    {
        SceneManager.LoadScene("Main");
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
