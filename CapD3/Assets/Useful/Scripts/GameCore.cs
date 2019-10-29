using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject StageSelectBtn;
    [SerializeField] private GameObject resetbtn;
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject btncanvas;
    [SerializeField] private GameObject pausecanvas;
    [SerializeField] private GameObject resumebtn;
    [SerializeField] private GameObject NextStgBtn;
    [SerializeField] private GameObject ScoreboardBtn;

    [SerializeField] private GameObject Tmanager;
    public GameObject InputName;
    public GameObject InputButton;
    private TutorialManagerScript Tmanagerscript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            if (!Tmanager)
            {
                Time.timeScale = 0;
                InputName.SetActive(true);
                InputButton.SetActive(true);
                btncanvas.SetActive(false);
                pausecanvas.SetActive(true);
                NextStgBtn.SetActive(true);
                ScoreboardBtn.SetActive(true);
                resumebtn.SetActive(false);
                if(text1)
                    text1.SetActive(true);
                if (timer)
                {
                    TimerScript temptimer = timer.GetComponent<TimerScript>();
                    temptimer.timepassoff();
                }
                
                this.gameObject.SetActive(false);
                Invoke("deavtivate", 2);
            }
            else
            {
                int i = Tmanagerscript.gettercontine();
                if(i == 12)
                {
                    Tmanagerscript.addcontinue();
                }
                this.gameObject.SetActive(false);
            }
        }
    }

    void deavtivate()
    {
        if(text1)
            text1.SetActive(false);
        if(resetbtn)
            resetbtn.SetActive(true);
        if(StageSelectBtn)
            StageSelectBtn.SetActive(true);
    }
    void Start()
    {
        if (Tmanager)
            Tmanagerscript = Tmanager.GetComponent<TutorialManagerScript>();
    }
}
