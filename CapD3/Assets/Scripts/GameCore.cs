using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    //[SerializeField] private GameObject tank;
    //[SerializeField] private Canvas Maincanvas;
    [SerializeField] private GameObject text1;
    // Start is called before the first frame update
    [SerializeField] private GameObject StageSelectBtn;
    [SerializeField] private GameObject resetbtn;
    [SerializeField] private GameObject timer;

    [SerializeField] private GameObject Tmanager;
    private TutorialManagerScript Tmanagerscript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("플레이어가 코어접촉 플레이어 승리");
            if (!Tmanager)
            {
                text1.SetActive(true);
                TimerScript temptimer = timer.GetComponent<TimerScript>();
                temptimer.timepassoff();
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
            }
            
            
        }
        else
        {
            Debug.Log("예외발생 예상치못한 물체 코어에접촉");
        }
    }

    void deavtivate()
    {
        text1.SetActive(false);
        resetbtn.SetActive(true);
        StageSelectBtn.SetActive(true);
    }
    void Start()
    {
        if (Tmanager)
            Tmanagerscript = Tmanager.GetComponent<TutorialManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
