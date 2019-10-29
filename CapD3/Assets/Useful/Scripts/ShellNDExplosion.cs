using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellNDExplosion : MonoBehaviour
{
    public LayerMask m_TankMask;             
    public ParticleSystem m_ExplosionParticles;
    public AudioSource m_ExplosionAudio;
    public float m_MaxDamage = 20f;     
    public float m_ExplosionForce = 2000f;
    public float m_MaxLifeTime = 2f;      
    public float m_ExplosionRadius = 30f; 
    private void Start()
    {
        Destroy(gameObject, m_MaxLifeTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, m_ExplosionRadius, m_TankMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();
            if (!targetRigidbody)
            {
                continue;
            }

            targetRigidbody.AddExplosionForce(m_ExplosionForce, transform.position, m_ExplosionRadius);

            Complete.TankHealth targetHealth = targetRigidbody.GetComponent<Complete.TankHealth>();
            HealthForTurret targetHealth2 = targetRigidbody.GetComponent<HealthForTurret>();
            BreakableWallScript targetHealth3 = targetRigidbody.GetComponent<BreakableWallScript>();

            float damage = 0;

            if (targetHealth)
            {
                targetHealth.TakeDamage(damage);
            }
            else if (targetHealth2)
            {
                targetHealth2.TakeDamage(damage);
            }
            else if (targetHealth3)
            {
                targetHealth3.TakeDamage(1);
            }
            else
            {
                continue;
            }
        }
        m_ExplosionParticles.transform.parent = null;
        m_ExplosionParticles.Play();
        m_ExplosionAudio.Play();

        ParticleSystem.MainModule mainModule = m_ExplosionParticles.main;
        Destroy(m_ExplosionParticles.gameObject, mainModule.duration);
        Destroy(gameObject);
    }


    private float CalculateDamage(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;

        float explosionDistance = explosionToTarget.magnitude;
        float relativeDistance = (m_ExplosionRadius - explosionDistance) / m_ExplosionRadius;
        float damage = relativeDistance * m_MaxDamage;
        damage = Mathf.Max(0f, damage);
        Debug.Log(damage);

        return damage;
    }
}

