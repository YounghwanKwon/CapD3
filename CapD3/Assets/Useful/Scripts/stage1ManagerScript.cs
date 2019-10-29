using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage1ManagerScript : MonoBehaviour
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
    private float frequency = 1.5f;

    [SerializeField] private GameObject air;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject motherpipe;
    [SerializeField] private GameObject[] pipes;
    [SerializeField] private GameObject[] planes;
    [SerializeField] private GameObject dropshell2;
    [SerializeField] private GameObject dropshell3;
    [SerializeField] private float leftdifficulty ;
    [SerializeField] private Text text1;

    private IngameCanvasScript igcvsscript;

    // Start is called before the first frame update
    void Start()
    {
        StageSaveScript.StageNum = 1;
        ResetBtnScript rsbtnscript = resetbtn.GetComponent<ResetBtnScript>();
        rsbtnscript.setstage(1);
        text1.text = "Stage : 1";

        igcvsscript = igcanvas.GetComponent<IngameCanvasScript>();
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("다음 지시사항을 참고하여 임무를 완료하시오 \n 지시사항 : 노란색 화살표를 찾아서 이동할것");
    }
    public void order1fneww()
    {
        igcvsscript.upsentenceononly();
        igcvsscript.setupsentence("다음 노란색 화살표를 찾아서 화살표 방향으로 이동하시오");
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
    public void bookingoff()
    {
        igcvsscript.upsentenceoffonly();
    }
    public void makeboomstop1()
    {
        needboomleft = false;
    }
    public void bombleftA()
    {
        if (needboomleft == true)
        {
            for (int i = 0; i < 18; i++)
            {
                if (i % 2 == 0)
                {
                    ground = pipes[i];
                    air.transform.position = ground.transform.position;
                    Drophere2(air.transform);
                }
            }
            Invoke("bombleftB", Time.deltaTime*51);
        }
    }
    public void bombleftB()
    {
        if (needboomleft)
        {
            for (int i = 0; i < 18; i++)
            {
                if (i % 2 == 1)
                {
                    ground = pipes[i];
                    air.transform.position = ground.transform.position;
                    Drophere2(air.transform);
                }
            }
            Invoke("bombleftA", Time.deltaTime * 51);
        }
    }
    void setxpos(Transform Atransform)
    {
        xvalue *= -1;
        Atransform.transform.position = new Vector3(xvalue, Atransform.transform.position.y, Atransform.transform.position.z);
    }
    void Drophere(Transform Atransform)
    {
        GameObject thisshell = Instantiate(shell1, Atransform);
        thisshell.transform.parent = null;
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
            for (int i = 0; i < transnumber; i++)
            {
                transs.transform.position = new Vector3(xvalue, BombPlacingPoint1.transform.position.y, BombPlacingPoint1.transform.position.z - 5.0f * i);
                setxpos(transs);
                Drophere(transs);
            }
            Invoke("setandbombattranss", Time.deltaTime*90);
        }
    }
    public void makeboomstop()
    {
        needboom1 = false;
    }
}
