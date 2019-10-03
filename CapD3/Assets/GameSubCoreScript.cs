using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSubCoreScript : MonoBehaviour
{
    public static int SubCorecount;
    [SerializeField] private GameObject drone;
    [SerializeField] private GameObject gamecore;
    [SerializeField] private GameObject stage1Manager;
    private stage1ManagerScript s1mscript;
    [SerializeField] private GameObject captureslider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            SubCorecount++;
            Debug.Log("플레이어가 서브코어접촉 정상 감지1 subcorecount : "+SubCorecount);
            if (SubCorecount == 1 || SubCorecount == 2)
                s1mscript.order1fneww();
            
            this.gameObject.SetActive(false);
            check3();
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
            s1mscript.order4bosson();
            checkreset();
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
