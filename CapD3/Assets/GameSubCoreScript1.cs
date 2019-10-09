using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript1 : MonoBehaviour
{
    public static int SubCorecount = 0;

    //[SerializeField] private GameObject gamecore;
    [SerializeField] private GameObject stage1Manager;
    [SerializeField] private GameObject stage1HDMDManager;
    [SerializeField] private GameObject downarrow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            boomstopcheck();
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
        else if (stage1HDMDManager)
        {
            stage1HDMDManagerScript stage1HDMDscript = stage1HDMDManager.GetComponent<stage1HDMDManagerScript>();
            if (stage1HDMDscript)
            {
                stage1HDMDscript.makeboomstop();
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
                Debug.Log("stop?");
            }
            else
                Debug.Log("no lab2script");
        }
        else
            Debug.Log("no lab2manager");
    }

    void deactive()
    {
        downarrow.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public void checkreset()
    {
        SubCorecount = 0;
    }

    private void check3()
    {
        if (SubCorecount == 3)
        {
            //gamecore.SetActive(true);
            checkreset();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
