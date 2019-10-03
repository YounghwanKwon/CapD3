using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] canvass;
    private IngameCanvasScript ingamecanvascript1;
    private int continuing;
    [SerializeField] private GameObject particle;
    [SerializeField] private GameObject resetbtn;

    // Start is called before the first frame update
    void Start()
    {
        
        continuing = 0;
        ingamecanvascript1 = canvass[2].GetComponent<IngameCanvasScript>();
        ingamecanvascript1.fortutorial();
        ResetBtnScript resetbtnscript = resetbtn.GetComponent<ResetBtnScript>();
        resetbtnscript.setstage(0);
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
    public int gettercontine()
    {
        return continuing;
    }

    // Update is called once per frame
    void Update()
    {
        //ingamecanvascript1.setsentence(8, "");의 반복
        //sentence(""+continuing);
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
            sentence("빨간색 불꽃이 일어나는곳으로 가보십시요" + continuing);
            particle.transform.position = new Vector3(10, 0, 0);
            particle.SetActive(true);
        }
        else if (continuing == 3)
        {
            sentence("탱크의 주변 평면의 원이 당신의 체력상태를 나타냅니다.\n적에게 과한 피격을 당할 시\n 게임 오버가 될 수 있으므로 주의하셔야합니다." + continuing);
        }
        else if (continuing == 4)
        {
            sentence("빨간색 불꽃이 일어나는곳으로 가보십시요." + continuing);
            particle.transform.position = new Vector3(15, 0, 0);
        }
        else if (continuing == 5)
        {
            sentence("체력을 회복하고싶을 때는 힐링 캡슐을 찾으십시요." + continuing);
        }
        else if (continuing == 6)
        {
            particle.SetActive(false);
            sentence("유저의 탱크도 사격 버튼을 이용하여 공격 할 수 있습니다.\n 사격 버튼을 누르십시요" + continuing);
        }
        else if (continuing == 7)
        {
            sentence("튜토리얼 맵에서는 탄의 제한이 없으나\n 실전맵에서는 탄을 아껴야합니다." + continuing);
        }
        else if (continuing == 8)
        {
            sentence("게임에서 승리하기 위해서는 승리 조건을 달성시켜야 합니다.\n 승리 조건이 거점 점령일 경우부터 알아 보도록하겠습니다." + continuing);
        }
        else if (continuing == 9)
        {
            sentence("빨간색 불꽃이 일어나는곳으로 가보십시요" + continuing);
            particle.transform.position = new Vector3(-15, 0, -1.7f);
            particle.SetActive(true);
            ingamecanvascript1.setactive(3);
        }
        else if (continuing == 10)
        {
            sentence("거점 점령 시에는 거점과 가까운 거리 내에\n플레이어가 존재해야합니다." + continuing);
        }
        else if (continuing == 11)
        {
            particle.SetActive(false);
            sentence("이번에는 게임 승리 조건이 '특정 목표' 획득일 때\n 승리 하는 방법에 대해 알아보겠습니다." + continuing);
        }
        else if (continuing == 12)
        {
            sentence("빨간색 불꽃이 일어나는곳으로 가보십시요" + continuing);
            particle.transform.position = new Vector3(30, 0, 0);
            particle.SetActive(true);
        }
        else if (continuing == 13)
        {
            sentence("특정목표 획득은 특정 목표를 찾아서 획득하는 것으로 게임을 승리하게 됩니다." + continuing);
            particle.SetActive(false);
        }
        else if (continuing == 14)
        {
            sentence("다음은 새로 추가된 방해 요소에 대해서 알아보겠습니다.\n빨간 불꽃이 일어나는 곳으로 이동하십시오" + continuing);
            particle.transform.position = new Vector3(10, 0, -7.5f);
            particle.SetActive(true);
        }
        else if (continuing == 15)
        {
            sentence("레이저의 데미지는 100입니다.\n 튜토리얼이 아닌 맵에서는 레이저를 조심하세요." + continuing);
            particle.SetActive(false);
        }
        else if (continuing == 16)
        {
            sentence("모든 튜토리얼을 끝냈습니다. 축하합니다.!" + continuing);
            PauseCanvasScript canvasscipt2 = canvass[1].GetComponent<PauseCanvasScript>();
            canvasscipt2.whenuserdead();
            ingamecanvascript1.setactive(11);
        }
        else
        {
            ingamecanvascript1.setsentence(8, "" + continuing);
            Debug.Log(continuing);
        }
    }
}
