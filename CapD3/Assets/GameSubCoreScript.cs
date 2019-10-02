using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript : MonoBehaviour
{
    public static int SubCorecount;
    [SerializeField] private GameObject drone;
    [SerializeField] private GameObject gamecore;
    [SerializeField] private GameObject Lab2Manager;
    [SerializeField] private GameObject captureslider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            SubCorecount++;
            Debug.Log("플레이어가 서브코어접촉 정상 감지1 subcorecount : "+SubCorecount);
            this.gameObject.SetActive(false);
            check3();
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
        SubCorecount = 0;
    }

    public void checkreset()
    {
        SubCorecount = 0;
    }

    private void check3()
    {
        if(SubCorecount == 3)
        {
            //gamecore.SetActive(true);
            drone.SetActive(true);
            MovementE moveE = drone.GetComponent<MovementE>();
            moveE.poweronfunc();
            captureslider.gameObject.SetActive(false);
            checkreset();
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
