using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Def : MonoBehaviour
{
    public GameObject Tank;
    
    void OnDisable()
    {
        Complete.TankHealth targetHealth = Tank.GetComponent<Complete.TankHealth>();
        targetHealth.TakeDamage(1000f);
    }
}
