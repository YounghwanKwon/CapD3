using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubewallrighttrigger : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject s1manager;
    [SerializeField] private GameObject s1HDMDmanager;
    private stage1ManagerScript s1mscript;
    private stage1HDMDManagerScript s1HDMDmscript;

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
        //stage1ManagerScript s1managerscript = s1manager.GetComponent<stage1ManagerScript>();
        if (s1manager)
            s1mscript.order2fbc();
        else if (s1HDMDmanager)
            s1HDMDmscript.order2fbc();
        else
            Debug.Log("error7");
this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (s1manager)
            s1mscript = s1manager.GetComponent<stage1ManagerScript>();
        else if (s1HDMDmanager)
            s1HDMDmscript = s1HDMDmanager.GetComponent<stage1HDMDManagerScript>();
        else
            Debug.Log("error6");
            
    }

    // Update is called once per frame
    void Update()
    {

    }
}
