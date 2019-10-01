using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript1 : MonoBehaviour
{
    public static int SubCorecount = 0;

    [SerializeField] private GameObject gamecore;
    [SerializeField] private GameObject Lab2Manager;
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
        if (Lab2Manager)
        {
            Lab2ManagerScript lab2script = Lab2Manager.GetComponent<Lab2ManagerScript>();
            if (lab2script)
            {
                lab2script.makeboomstop();
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
        if (Lab2Manager)
        {
            Lab2ManagerScript lab2script = Lab2Manager.GetComponent<Lab2ManagerScript>();
            if (lab2script)
            {
                lab2script.makeboomstop1();
                Debug.Log("stop?");
            }
            else
                Debug.Log("no lab2script");
        }
        else
            Debug.Log("no lab2manager");
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
            gamecore.SetActive(true);
            checkreset();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
