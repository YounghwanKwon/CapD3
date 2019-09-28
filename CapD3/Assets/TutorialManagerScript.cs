using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] canvass;
    private IngameCanvasScript ingamecanvascript1;
    private int continuing;

    // Start is called before the first frame update
    void Start()
    {
        continuing = 0;
        ingamecanvascript1 = canvass[2].GetComponent<IngameCanvasScript>();
    }
    public void addcontinue()
    {
        continuing++;
        Debug.Log(continuing);
    }
    public void minuscontine()
    {
        continuing--;
        Debug.Log(continuing);
    }
    public void sentence(string strings)
    {
        ingamecanvascript1.setsentence(8, strings);
    }


    // Update is called once per frame
    void Update()
    {
        //ingamecanvascript1.setsentence(8, "");의 반복
        if (continuing == 0)
        {
            sentence("튜토리얼에 오신것을 환영합니다!\n 튜토리얼의 진행은 화면을 터치함으로써\n 진행할 수 있습니다.");
            //ingamecanvascript1.setsentence(8, "튜토리얼에 오신것을 환영합니다!\n 튜토리얼의 진행은 화면을 터치함으로써\n 진행할 수 있습니다.");
        }
        else if (continuing == 1)
        {
            ingamecanvascript1.setsentence(8, "캐릭터의 이동은 화면 촤측하단의 컨트롤러를 통하여 이동할수 있습니다!");
        }
        else if (continuing == 2)
        {
            sentence("게임 승리의 목적은 승리 조건 달성입니다.");
        }
        else if (continuing >= 3)
        {
            ingamecanvascript1.setsentence(8, "" + continuing);
        }
        /*else if (continuing == -5)
        {
            ingamecanvascript1.setsentence(8, "만든이 ScullyLoop" + continuing);
        }*/
        else
        {
            Debug.Log(continuing);
        }
    }
}
