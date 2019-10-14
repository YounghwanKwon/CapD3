using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage2ManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject igcanvas;
    [SerializeField] private GameObject resetbtn1;
    [SerializeField] private GameObject shell1;
    public static bool alive1;
    public static bool alive2;

    //[SerializeField] private Transform BombPlacingPoint1;
    private float xvalue = 2.5f;
    private Transform transs;
    private int transnumber = 15;
    private float frequency = 1.5f;

    [SerializeField] private GameObject air;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject dropshell2;
    [SerializeField] private GameObject dropshell3;
    [SerializeField] private float leftdifficulty = 0.85f;
    [SerializeField] private Text text1;
    private int first, after;

    private IngameCanvasScript igcvsscript;

    // Start is called before the first frame update
    void Start()
    {
        StageSaveScript.StageNum = 2;
        first = 0;
        after = 0;
        alive1 = true;
        alive2 = true;
        GameSubCoreScript.SubCorecount = 0;
        //bombleftA();
        //bombleftC();
        //setandbombattranss();
        ResetBtnScript rsbtnscript = resetbtn1.GetComponent<ResetBtnScript>();
        rsbtnscript.setstage(2);
        text1.text = "Stage : 2";

        igcvsscript = igcanvas.GetComponent<IngameCanvasScript>();
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("다음 지시사항을 참고하여 임무를 완료하시오 \n 지시사항 : 노란색 화살표를 찾아서 이동할것");

    }
    public void order1fneww()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("다음 노란색 화살표를 찾아서 화살표 방향으로 이동하시오");
        Invoke("bookingoff", 4);
    }
    public void order2fbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("현재 이동방향으로 이동하여 장애물을 극복하고 파란색 큐브를 획득하시오");
        Invoke("bookingoff", 4);
    }
    public void order3gooutright()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("탈출 가능!! 녹색 화살표를 따라서 탈출하고 파란색 큐브를 획득하시오");
    }
    public void order4bosson()
    {
        first++;
        igcvsscript.setupsentence("망치를 피하고 골렘들을 저지하십시오!!");
        Invoke("bookingoff", 5);
    }
    public void order2s2lfbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("퍼즐 구간입니다. \n남서쪽의 퍼즐을 보고 북동쪽의 퍼즐을 맞추시요");
        Invoke("bookingoff", 10);
    }
    public void order2s2l2fbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("퍼즐 구간 클리어!\n 북동쪽 다리의 파란색 큐브를 획득하시오");
        Invoke("bookingoff", 10);
    }
    public void order2s2dfbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("미로 구간입니다.\n 미로내의 힐팩으로 체력을 보충하며 미로의 출구로 가시오");
        Invoke("bookingoff", 10);
    }
    public void order2s2rfbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("폭탄 구간입니다. \n하얀색 발판에서 숨을 돌릴 수 있습니다.");
        Invoke("bookingoff", 10);
    }
    public void order2s2r2fbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("발판이 줄어들고있습니다!\n 하얀색 큐브를 최대한 빨리 찾으십시오!!");
        Invoke("bookingoff", 15);
    }
    public void order2s2ddfbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("오일 저장소를 지키십시오!!\n 플레이어는 포탄 또는 몸으로 방어할수있습니다!!");
        Invoke("bookingoff", 35);
    }
    public void order2s2dd2fbc()
    {
        first++;
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("큐브를 통하여 다음장소로 이동하십시오");
    }
    public void bookingoff()
    {
        after++;
        if(first == after)
            igcvsscript.upsentenceoffonly();
    }

    /*
    public void makeboomstop1()
    {
        needboomleft = false;
    }
    */
    /*
    private void bombleft()
    {
        if (needboomleft == true)
        {
            //air.transform.position = ground.transform.position;

            for (int i = 0; i < 18; i++)
            {
                ground = pipes[i];
                air.transform.position = ground.transform.position;
                Drophere2(air.transform);
            }
            Invoke("bombleft", 3f);
        }
    }
    public void bombleftA()
    {
        if (needboomleft == true)
        {
            //air.transform.position = ground.transform.position;

            for (int i = 0; i < 18; i++)
            {
                if (i % 2 == 0)
                {
                    ground = pipes[i];
                    air.transform.position = ground.transform.position;
                    Drophere2(air.transform);
                }
            }
            Invoke("bombleftB", leftdifficulty);
        }
    }

    public void bombleftB()
    {
        if (needboomleft)
        {
            //air.transform.position = ground.transform.position;

            for (int i = 0; i < 18; i++)
            {
                if (i % 2 == 1)
                {
                    ground = pipes[i];
                    air.transform.position = ground.transform.position;
                    Drophere2(air.transform);
                }
            }
            Invoke("bombleftA", leftdifficulty);
        }
    }
    void bombleftC()
    {
        if (needboomleft == true)
        {
            air.transform.position = ground.transform.position;

            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    ground = planes[i];
                    air.transform.position = ground.transform.position;
                    Drophere3(air.transform);
                }
            }
            Invoke("bombleftD", leftdifficulty);
        }
    }

    void bombleftD()
    {
        if (needboomleft)
        {
            air.transform.position = ground.transform.position;

            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 1)
                {
                    ground = planes[i];
                    air.transform.position = ground.transform.position;
                    Drophere3(air.transform);
                }
            }
            Invoke("bombleftC", leftdifficulty);
        }
    }
    */
    void setpipes()
    {
        Debug.Log(transform.childCount);
        //GameObject[] planes1 = new GameObject[transform.childCount];
        //GameObject[] planes1 = motherplane.GetComponentsInChildren<GameObject>();
        /*
        for (int i = 0; i<planes1.Length; i++)
        {
            pipes[i] = planes1[i].gameObject;
        }
        */
    }


    void setxpos(Transform Atransform)
    {
        //Debug.Log("called setxpos169");
        xvalue *= -1;
        Atransform.transform.position = new Vector3(xvalue, Atransform.transform.position.y, Atransform.transform.position.z);
    }

    void Drophere(Transform Atransform)
    {

        //Debug.Log("called Drop258");
        //setxpos(Atransform);
        GameObject thisshell = Instantiate(shell1, Atransform);
        thisshell.transform.parent = null;
        //Instantiate(shell1,new Vector3(0,0.1f,0),Quaternion.Euler(Vector3.zero));
        //Invoke("DropA", 2);
    }
    void Drophere2(Transform Atransform)
    {
        GameObject thisshell = Instantiate(dropshell2, Atransform);
        thisshell.transform.parent = null;
    }
    void Drophere3(Transform Atransform)
    {
        GameObject thisshell = Instantiate(dropshell3, Atransform);
        thisshell.transform.parent = null;
    }

    /*
    public void setandbombattranss()
    {
        if (needboom1 == true)
        {
            transs = transform;
            //Debug.Log(BombPlacingPoint1.transform+"3");
            for (int i = 0; i < transnumber; i++)
            {
                //Debug.Log("BombPlacingPoint1"+BombPlacingPoint1 + "47");
                //Debug.Log("x"+xvalue);
                //Debug.Log("y" + BombPlacingPoint1.transform.position.y);
                //Debug.Log("z" + BombPlacingPoint1.transform.position.z);
                transs.transform.position = new Vector3(xvalue, BombPlacingPoint1.transform.position.y, BombPlacingPoint1.transform.position.z - 5.0f * i);
                //Debug.Log(i);
                setxpos(transs);
                Drophere(transs);
            }
            Invoke("setandbombattranss", frequency);
        }
    }
    *//*

    public void makeboomstop()
    {
        needboom1 = false;
    }
    */

    // Update is called once per frame
    void Update()
    {

    }
    void checktime(float atime)
    {
        float a = 0;
        a += Time.deltaTime;
        //needboom = true;
        Debug.Log("2sec");
    }
}
