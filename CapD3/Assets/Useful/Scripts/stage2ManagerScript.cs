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
        igcvsscript.setupsentence("퍼즐 구간입니다. \n남서쪽의 퍼즐을 보고 북동쪽의 퍼즐을 맞추시오");
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
}
