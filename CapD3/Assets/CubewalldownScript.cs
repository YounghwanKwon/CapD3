using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubewalldownScript : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject s1manager;

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
        stage1ManagerScript s1managerScript = s1manager.GetComponent<stage1ManagerScript>();
        s1managerScript.setandbombattranss();
        s1managerScript.order2fbc();
        this.gameObject.SetActive(false);
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
