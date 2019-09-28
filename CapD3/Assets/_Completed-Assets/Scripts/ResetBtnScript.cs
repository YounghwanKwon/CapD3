using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetBtnScript : MonoBehaviour
{
    [SerializeField] private GameObject newtestmap;
    [SerializeField] private GameObject newtesttank;
    [SerializeField] private GameObject newHP;


    [SerializeField] private GameObject oldCP;
    [SerializeField] private GameObject oldGC;
    [SerializeField] private GameObject oldtank;
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject exitBtn;
    //[SerializeField] private GameObject completedtuesdaymap;
    // Start is called before the first frame update

    public void whenresetbtnpressed()
    {
        SceneManager.LoadScene("stage1");
        //Debug.Log("reset버튼이 눌림");
        //ExitScript escscript = exitBtn.GetComponent<ExitScript>();
        //escscript.countup();
        //tryreset();
    }

    void tryreset()
    {
        oldtank.transform.position = new Vector3(0, 0, 0);
        oldtank.transform.rotation = Quaternion.Euler(0, 90, 0);//탱크 재배치
        Complete.TankHealth temptank = oldtank.GetComponent<Complete.TankHealth>();//탱크 체력회복
        temptank.fullrecovery();

        oldGC.SetActive(true); //게임코어 재배치

        CapturePoint tempCP = oldCP.GetComponent<CapturePoint>();
        tempCP.CPreset(); //거점 점령시간초기화

        Complete.TankShooting temptankshooting = oldtank.GetComponent<Complete.TankShooting>();
        temptankshooting.refillbullet(); //총알 재보급

        TimerScript temptimer = timer.GetComponent<TimerScript>(); //시간 0초부터 다시재생
        temptimer.timezerofy();
        temptimer.timepasson();

        this.gameObject.SetActive(false);
        /*
        destorypart();
        instantiatepart();
        movingpart();
        */
    }
    void destorypart()
    {

    }
    void instantiatepart()
    {

    }
    void movingpart()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
