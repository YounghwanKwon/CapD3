using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubewallrighttrigger : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject s1manager;
    [SerializeField] private GameObject s1HDMDmanager;
    [SerializeField] private GameObject s2manager;
    [SerializeField] private GameObject s2righttrigger;
    private stage1ManagerScript s1mscript;
    private stage1HDMDManagerScript s1HDMDmscript;
    private stage2ManagerScript s2mscript;

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
            s1mscript.order2fbc();
        else if (s1HDMDmanager)
            s1HDMDmscript.order2fbc();
        else if (s2manager)
        {
            s2mscript.order2s2rfbc();
            s2righttrigger.SetActive(true);
        }
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (s1manager)
            s1mscript = s1manager.GetComponent<stage1ManagerScript>();
        else if (s1HDMDmanager)
            s1HDMDmscript = s1HDMDmanager.GetComponent<stage1HDMDManagerScript>();
        else if (s2manager)
            s2mscript = s2manager.GetComponent<stage2ManagerScript>();
    }
}
