using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] maps;
    [SerializeField] private GameObject[] canvas;
    [SerializeField] private GameObject[] tanks;
    [SerializeField] private GameObject[] turretsset;
    [SerializeField] private Text[] texts;
    private int stagenumber=-1;
    public void TutorialBtnPressed()
    {
        texts[0].text = "Learning how to play this game";
        texts[1].text = "You can learn \nhow to move, shoot, heal\n what to do to win";
        stagenumber = 0;
        //SceneManager.LoadScene("Tutorial");
    }
    public void Stage1BtnPressed()
    {
        texts[0].text = "Destroy 'the Boss'(drone type)";
        texts[1].text = "Collect blue cube 3 times\n(Follow the yellow arrow direction)";
        stagenumber = 1;
        //SceneManager.LoadScene("Stage1");
    }
    public void Stage1HDMDBtnPressed()
    {
        texts[0].text = "Destroy 'the Boss'(drone type)";
        texts[1].text = "Collect blue cube 3 times\n(Follow the yellow arrow direction)";
        stagenumber = 101;
        //SceneManager.LoadScene("Stage1");
    }
    public void Stage2BtnPressed()
    {
        texts[0].text = "Developing";
        texts[1].text = "Developing";
        stagenumber = 2;
        //SceneManager.LoadScene("Stage2");
    }
    public void Lab2BtnPressed()
    {
        SceneManager.LoadScene("Stage1hardmode");
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

    public void whenstartbtnpressed()
    {
        if (stagenumber == -1)
            whenstartfored();
        else if (stagenumber == 0)
            SceneManager.LoadScene("Tutorial");
        else if (stagenumber == 1)
            SceneManager.LoadScene("Stage1");
        else if (stagenumber == 2)
            SceneManager.LoadScene("Stage2");
        else if (stagenumber == 101)
            SceneManager.LoadScene("Stage1hardmode");
        else
            Debug.Log(stagenumber);

    }
    public void whenstartfored()
    {
        texts[0].text = "";
        texts[1].text = "Select stage first\n And Enjoy it";
        Debug.Log(stagenumber);
    }

    public void StageSelectCanvasDisappearing()
    {
        this.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        texts[0].text = "";
        texts[1].text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
