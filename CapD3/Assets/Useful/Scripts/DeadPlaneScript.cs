using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlaneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Rigidbody targetRigidbody = other.GetComponent<Rigidbody>();

            Complete.TankHealth targetHealth = targetRigidbody.GetComponent<Complete.TankHealth>();
            targetHealth.TakeDamage(100.0f);
        }
    }
}
