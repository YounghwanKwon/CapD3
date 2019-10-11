using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage1HDMDManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject igcanvas;
    [SerializeField] private GameObject resetbtn;
    [SerializeField] private GameObject shell1;

    [SerializeField] private Transform BombPlacingPoint1;
    private float xvalue = 2.5f;
    private Transform transs;
    private int transnumber = 15;
    private bool needboom1 = true;
    private bool needboomleft = true;
    private float frequency;
    private bool readypolution = false;

    [SerializeField] private GameObject air;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject motherpipe;
    [SerializeField] private GameObject[] pipes;
    [SerializeField] private GameObject[] planes;
    [SerializeField] private GameObject dropshell2;
    [SerializeField] private GameObject dropshell3;
    [SerializeField] private float leftdifficulty;
    [SerializeField] private Text text1;

    private IngameCanvasScript igcvsscript;

    // Start is called before the first frame update
    void Start()
    {
        StageSaveScript.StageNum = 101;
        //bombleftA();
        //bombleftC();
        //setandbombattranss();
        ResetBtnScript rsbtnscript = resetbtn.GetComponent<ResetBtnScript>();
        rsbtnscript.setstage(1);
        text1.text = "Stage : hardmode1";
        if(leftdifficulty == 0)
        {
            leftdifficulty = 0.85f;
        }
        if (frequency == 0)
            frequency = 2.25f;

        igcvsscript = igcanvas.GetComponent<IngameCanvasScript>();

        //Debug.Log(planes);

        //setxpos(BombPlacingPoint1);
        //DropA(BombPlacingPoint1);
        //setandbombattranss();
        //setpipes();
    }
    public void order0whenstart()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("다음 지시사항을 참고하여 임무를 완료하시오 \n 지시사항 : 노란색 화살표를 찾아서 이동할것");
        Invoke("order0whenstart1", 1);
    }
        public void order0whenstart1()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("다음 지시사항을 참고하여 임무를 완료하시오 \n 지시사항 : 노란색 화살표를 찾아서 이동할것");
    }
    public void order1fneww()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("다음 노란색 화살표를 찾아서 화살표 방향으로 이동하시오");
        Debug.Log("where?");
        Invoke("bookingoff", 4);
    }
    public void order2fbc()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("현재 이동방향으로 이동하여 장애물을 극복하고 파란색 큐브를 획득하시오");
        Invoke("bookingoff", 4);
    }
    public void order3gooutright()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("탈출 가능!! 녹색 화살표를 따라서 탈출하고 파란색 큐브를 획득하시오");
    }
    public void order4bosson()
    {
        igcvsscript.setupsentence("보스 출현!! 보스를 제거하고 보스에게서 빨간색 전리품을 획득하시오");
        Invoke("bookingoff", 5);
    }
    public void order2_1lfbc()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("숨겨진 큐브가 생성되었습니다. 다음 파란색 큐브를 획득하시오");
        Invoke("bookingoff", 5);
    }
    public void order2_1rfbc()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("적의 함정입니다!! 30초간 버티세요!!\n(주의 : 빨간 레이저는 더 데미지가 강함)");
        Invoke("bookingoff", 8);
    }
    public void order2_1dfbc()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("적의 방벽을 파괴하고 파란색 큐브를 획득하시오\n(주의 : 폭탄은 데미지가 강함)");
        Invoke("bookingoff", 8);
    }
    public void bookingoff()
    {
        igcvsscript.upsentenceoffonly();
    }
    public void makeboomstop1()
    {
        needboomleft = false;
    }

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

    public void makeboomstop()
    {
        needboom1 = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(IngameCanvasScript.fullready == true && readypolution == false)
        {
            readypolution = true;
            order0whenstart();
        }
    }
    void checktime(float atime)
    {
        float a = 0;
        a += Time.deltaTime;
        //needboom = true;
        Debug.Log("2sec");
    }
}
