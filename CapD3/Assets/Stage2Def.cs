using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Def : MonoBehaviour
{
    public GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDisable()
    {
        TankHealth targetHealth = Tank.GetComponent<TankHealth>();
        targetHealth.TakeDamage(1000f);
    }
}
