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
    [SerializeField] private GameObject roundmove2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            SubCorecount++;
            if (SubCorecount == 1 || SubCorecount == 2)
                if (stage1Manager)
                    s1mscript.order1fneww();
                else if(stage1HDMDManager)
                    s1HDMDmscript.order1fneww();
                else if (stage2Manager)
                    s2mscript.order1fneww();
            this.gameObject.SetActive(false);
            Invoke("check3", 0.3f);
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
        
        if(StageSaveScript.StageNum != 2)
        {
            SubCorecount = 0;
        }
    }

    private void check3()
    {
        if(SubCorecount == 3)
        {
            settingbosson();
            if (stage1Manager)
                s1mscript.order4bosson();
            else if (stage1HDMDManager)
                s1HDMDmscript.order4bosson();
            else if (roundmove2)
            {
                roundmove2.SetActive(true);
                s2mscript.order2s2ddfbc();
            }
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
}
