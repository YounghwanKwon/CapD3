using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubewallrighttrigger : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject s1manager;
    private stage1ManagerScript s1mscript;

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
        s1mscript.order2fbc();
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (s1manager)
            s1mscript = s1manager.GetComponent<stage1ManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
