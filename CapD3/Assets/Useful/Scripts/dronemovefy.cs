using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dronemovefy : MonoBehaviour
{
    [SerializeField] private GameObject drone;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dronemove();
        }
    }
    public void dronemove()
    {
        MovementE moveE = drone.GetComponent<MovementE>();
        moveE.poweronfunc();
    }
}
