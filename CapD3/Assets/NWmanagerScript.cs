using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NWmanagerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] hammers;
    [SerializeField] private GameObject[] boss;
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject btncanvas;
    [SerializeField] private GameObject pausecanvas;
    [SerializeField] private GameObject resumebtn;
    [SerializeField] private GameObject NextStgBtn;
    [SerializeField] private GameObject ScoreboardBtn;
    private bool alive1;
    private bool alive2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hammers.Length; i++)
            hammers[i].SetActive(true);
        for (int i = 0; i < boss.Length; i++)
            boss[i].SetActive(true);
        alive1 = true;
        alive2 = true;
    }
    public void setdisactive1()
    {
        alive1 = false;
        checkplayerwinNW();
    }
    public void setdisactive2()
    {
        alive2 = false;
        checkplayerwinNW();
    }
    public void checkplayerwinNW()
    {
        if(!alive1 && !alive2)
        {
            TimerScript ts = GameObject.FindWithTag("Timer").GetComponent<TimerScript>();
            StageSaveScript sss = GameObject.FindWithTag("StageSave").GetComponent<StageSaveScript>();
            sss.Makerecord1fortest("Username1", ts.gettc2());
            Time.timeScale = 0;
            Debug.Log("UI player win need");
            winUI.SetActive(true);
            btncanvas.SetActive(false);
            pausecanvas.SetActive(true);
            NextStgBtn.SetActive(true);
            ScoreboardBtn.SetActive(true);
            resumebtn.SetActive(false);

            if (timer)
            {
                TimerScript temptimer = timer.GetComponent<TimerScript>();
                temptimer.timepassoff();
            }

        }
        else
            Debug.Log("not enough : "+alive1 +" "+ alive2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
