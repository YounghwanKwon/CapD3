using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerDamage : MonoBehaviour
{
    public LayerMask m_TankMask;                        
    public ParticleSystem m_ExplosionParticles;        
    public AudioSource m_ExplosionAudio;          
    public float m_MaxDamage = 100f;               
    public float m_ExplosionForce = 1000f;         
    public float m_MaxLifeTime = 2f;                  
    public float m_ExplosionRadius = 5f;            
   
    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, m_ExplosionRadius, m_TankMask);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();

            if (!targetRigidbody)
                continue;

            Complete.TankHealth targetHealth = targetRigidbody.GetComponent<Complete.TankHealth>();
            HealthForTurret targetHealth2 = targetRigidbody.GetComponent<HealthForTurret>();

            float damage = 10;

            if (targetHealth)
            {
                targetHealth.TakeDamage(damage);
            }
            else if (targetHealth2)
            {
                targetHealth2.TakeDamage(damage);
            }
            else
                continue;
        }
    }
}
