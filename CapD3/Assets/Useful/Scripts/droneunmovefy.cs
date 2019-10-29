using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneunmovefy : MonoBehaviour
{
    [SerializeField] private GameObject drone;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            droneunmove();
        }
    }
    public void droneunmove()
    {
        MovementE moveE = drone.GetComponent<MovementE>();
        moveE.powerofffunc();
    }
}
