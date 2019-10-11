using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    [SerializeField] private GameObject Buttoncanvas;
    public static bool fullready=false;
    private float deltaTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        makefpstext();
    }
    public void whenstartBtningamepressed()
    {
        setdisactive(15);
        setsentence(14, "3");
        Invoke("whencount2", 1);
    }
    private void whencount2()
    {
        setsentence(14, "2");
        Invoke("whencount1", 1);
    }
    private void whencount1()
    {
        setsentence(14, "1");
        Invoke("whencount0", 1);
    }
    private void whencount0()
    {
        setsentence(14, "Start !");
        Invoke("whencount_1", 1);
    }
    private void whencount_1()
    {
        setdisactive(14);
        Buttoncanvas.SetActive(true);
        setactive(6);
        fullready = true;
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    public void whenuserdead()
    {
        childrens[4].SetActive(true);
        childrens[12].SetActive(false);
        TimerScript timer = childrens[6].GetComponent<TimerScript>();
        timer.timepassoff();
    }
    public void setstagenumber(int number)
    {
        Text text1 = childrens[7].GetComponent<Text>();
        text1.text = "Stage Number : " + number;
    }

    public void setsentence(int i,string strings)
    {
        Text text1 = childrens[i].GetComponent<Text>();
        text1.text = strings;
    }
    public void setupsentence(string strings)
    {
        Text text1 = childrens[8].GetComponent<Text>();
        text1.text = strings;
    }
    public void setactive(int i)
    {
        childrens[i].SetActive(true);
    }
    public void setdisactive(int i)
    {
        childrens[i].SetActive(false);
    }
    public void fortutorial()
    {
        childrens[8].SetActive(true);
        childrens[9].SetActive(true);
        childrens[10].SetActive(true);
    }
    public void upsentenceononly()
    {
        childrens[8].SetActive(true);
    }
    public void upsentenceoffonly()
    {
        childrens[8].SetActive(false);
    }
    public void makefpstext()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = Mathf.Round(1f / deltaTime);
        if (childrens[13])
        {
            Text FPSText = childrens[13].GetComponent<Text>();
            FPSText.text = "FPS : " + fps.ToString();
        }
        
    }
}
