using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript : MonoBehaviour
{
    public static int SubCorecount;
    [SerializeField] private GameObject drone;
    [SerializeField] private GameObject gamecore;
    [SerializeField] private GameObject stage1Manager;
    [SerializeField] private GameObject stage1HDMDManager;
    [SerializeField] private GameObject stage2Manager;
    private stage1ManagerScript s1mscript;
    private stage1HDMDManagerScript s1HDMDmscript;
    private stage2ManagerScript s2mscript;
    [SerializeField] private GameObject captureslider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            SubCorecount++;
            Debug.Log("플레이어가 서브코어접촉 정상 감지1 subcorecount : "+SubCorecount);
            if (SubCorecount == 1 || SubCorecount == 2)
                if (stage1Manager)
                    s1mscript.order1fneww();
                else if(stage1HDMDManager)
                    s1HDMDmscript.order1fneww();
                else if (stage2Manager)
                    s2mscript.order1fneww();
                else
                    Debug.Log("error4");


            this.gameObject.SetActive(false);
            Invoke("check3", 0.3f);
        }
        else
        {
            Debug.Log("예외발생 예상치못한 물체 코어에접촉");
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        if (stage1Manager)
            s1mscript = stage1Manager.GetComponent<stage1ManagerScript>();
        else if (stage1HDMDManager)
            s1HDMDmscript = stage1HDMDManager.GetComponent<stage1HDMDManagerScript>();
        else if (stage2Manager)
            s2mscript = stage2Manager.GetComponent<stage2ManagerScript>();
        else
            Debug.Log("error2");
        if(StageSaveScript.StageNum != 2)
        {
            Debug.Log("초기화1");
            SubCorecount = 0;
        }
        
    }

    public void checkreset()
    {
        Debug.Log("초기화2");
        SubCorecount = 0;
    }

    private void check3()
    {
        if(SubCorecount == 3)
        {
            //gamecore.SetActive(true);
            settingbosson();
            if (stage1Manager)
                s1mscript.order4bosson();
            else if (stage1HDMDManager)
                s1HDMDmscript.order4bosson();
            else if (stage2Manager)
                //s2mscript.order4bosson();
                Debug.Log("stage2 need otherthing");
            else
                Debug.Log("error3");
        }
    }
  
    void settingbosson()
    {
        if (StageSaveScript.StageNum != 2)
        {
            drone.SetActive(true);
            MovementE moveE = drone.GetComponent<MovementE>();
            moveE.poweronfunc();
            captureslider.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
