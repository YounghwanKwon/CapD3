using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlaneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("유저충돌감지");
            Rigidbody targetRigidbody = other.GetComponent<Rigidbody>();

            Complete.TankHealth targetHealth = targetRigidbody.GetComponent<Complete.TankHealth>();
            targetHealth.TakeDamage(100.0f);

            this.gameObject.SetActive(false);
        }
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
