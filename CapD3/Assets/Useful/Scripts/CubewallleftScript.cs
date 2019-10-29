using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubewallleftScript : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject s1manager;
    [SerializeField] private GameObject s1HDMDmanager;
    [SerializeField] private GameObject s2manager;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            func1();
        }
    }
    
    public void func1()
    {
        wall.SetActive(true);
        if (s1manager)
        {
            stage1ManagerScript s1managerScript = s1manager.GetComponent<stage1ManagerScript>();
            s1managerScript.bombleftB();
            s1managerScript.order2fbc();
        }
        else if (s1HDMDmanager)
        {
            stage1HDMDManagerScript s1managerScript = s1HDMDmanager.GetComponent<stage1HDMDManagerScript>();
            s1managerScript.bombleftB();
            s1managerScript.order2fbc();
        }
        else if (s2manager)
        {
            stage2ManagerScript s2managerScript = s2manager.GetComponent<stage2ManagerScript>();
            s2managerScript.order2s2lfbc();
        }
        
        this.gameObject.SetActive(false);
    }
}
