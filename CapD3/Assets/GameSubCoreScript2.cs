using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript2 : MonoBehaviour
{

    //[SerializeField] private GameObject gamecore;
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
        else
        {
            Debug.Log("예외발생 예상치못한 물체 코어에접촉");
        }
    }

    void boomstopcheck()
    {
        if (stage1Manager)
        {
            stage1ManagerScript stage1script = stage1Manager.GetComponent<stage1ManagerScript>();
            if (stage1script)
            {
                stage1script.makeboomstop();
                deactive();
                Debug.Log("stop?");
            }
            else
                Debug.Log("no lab2script");
        }
        else
            Debug.Log("no lab2manager");
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
                Debug.Log("stop?");
            }
            else
                Debug.Log("no lab2script");
        }
        else if(stage1HDMDManager)
        {
            stage1HDMDManagerScript stage1HDMDscript = stage1HDMDManager.GetComponent<stage1HDMDManagerScript>();
            if (stage1HDMDscript)
            {
                stage1HDMDscript.makeboomstop1();
                deactive();
                Debug.Log("stop?");
            }
            else
                Debug.Log("no lab2script");
        }
        /*if (stage2Manager)
        {
            stage2ManagerScript stage2script = stage2Manager.GetComponent<stage2ManagerScript>();
            if (stage2script)
            {
                stage2script.makeboomstop1();
                deactive();
                Debug.Log("stop?");
            }
            else
                Debug.Log("no lab2script");
        }*/
        else
            Debug.Log("no lab2manager");
    }

    void deactive()
    {
        image.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

   
    // Update is called once per frame
    void Update()
    {

    }
}
