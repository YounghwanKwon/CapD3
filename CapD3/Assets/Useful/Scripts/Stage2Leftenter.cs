using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Leftenter : MonoBehaviour
{
    public GameObject LStage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            LStage.SetActive(true);
        }
    }
}
