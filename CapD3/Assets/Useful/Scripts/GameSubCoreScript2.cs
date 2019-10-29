using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript2 : MonoBehaviour
{
    [SerializeField] private GameObject stage1Manager;
    [SerializeField] private GameObject stage1HDMDManager;
    [SerializeField] private GameObject stage2Manager;
    [SerializeField] private GameObject Ingamehealpack;
    [SerializeField] private GameObject image;
    [SerializeField] private GameObject bots;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            boomstopcheck1();
            Destroy(bots);
            Ingamehealpack.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
    void boomstopcheck1()
    {
        if (stage1Manager)
        {
            stage1ManagerScript stage1script = stage1Manager.GetComponent<stage1ManagerScript>();
            if (stage1script)
            {
                stage1script.makeboomstop1();
                deactive();
            }
        }
        else if(stage1HDMDManager)
        {
            stage1HDMDManagerScript stage1HDMDscript = stage1HDMDManager.GetComponent<stage1HDMDManagerScript>();
            if (stage1HDMDscript)
            {
                stage1HDMDscript.makeboomstop1();
                deactive();
            }
        }
        else if (stage2Manager)
        {
            stage2ManagerScript stage2script = stage2Manager.GetComponent<stage2ManagerScript>();
            if (stage2script)
            {
                stage2script.order1fneww();
            }
        }
    }

    void deactive()
    {
        image.SetActive(false);
    }
}
