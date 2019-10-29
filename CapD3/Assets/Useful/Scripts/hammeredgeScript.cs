using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammeredgeScript : MonoBehaviour
{
    [SerializeField] private GameObject hammersshell;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hammersetground"))
        {
            GameObject shell = Instantiate(hammersshell, this.transform);
        }
        else if(other.CompareTag("Player"))
        {
            Complete.TankHealth TH = other.GetComponent<Complete.TankHealth>();
            TH.TakeDamage(100.0f);
        }
    }
}
