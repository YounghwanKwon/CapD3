using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateControler : MonoBehaviour
{
    public GameObject go1;
    [SerializeField] private GameObject s2m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter()
    {
        stage2ManagerScript s2ms = s2m.GetComponent<stage2ManagerScript>();
        s2ms.order2s2r2fbc();
        go1.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
