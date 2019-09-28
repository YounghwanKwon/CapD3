using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerDamage : MonoBehaviour
{
    public LayerMask m_TankMask;                        // Used to filter what the explosion affects, this should be set to "Players".
    public ParticleSystem m_ExplosionParticles;         // Reference to the particles that will play on explosion.
    public AudioSource m_ExplosionAudio;                // Reference to the audio that will play on explosion.
    public float m_MaxDamage = 100f;                    // The amount of damage done if the explosion is centred on a tank.
    public float m_ExplosionForce = 1000f;              // The amount of force added to a tank at the centre of the explosion.
    public float m_MaxLifeTime = 2f;                    // The time in seconds before the shell is removed.
    public float m_ExplosionRadius = 5f;                // The maximum distance away from the explosion tanks can be and are still affected.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Collect all the colliders in a sphere from the shell's current position to a radius of the explosion radius.
        Collider[] colliders = Physics.OverlapSphere(transform.position, m_ExplosionRadius, m_TankMask);

        // Go through all the colliders...
        for (int i = 0; i < colliders.Length; i++)
        {
            // ... and find their rigidbody.
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();


            // If they don't have a rigidbody, go on to the next collider.
            if (!targetRigidbody)
                continue;
            Debug.Log("강체있음1");

            // Add an explosion force.
            //targetRigidbody.AddExplosionForce(m_ExplosionForce, transform.position, m_ExplosionRadius);

            // Find the TankHealth script associated with the rigidbody.
            TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();
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

            // If there is no TankHealth script attached to the gameobject, go on to the next collider.
            /*
            if (!targetHealth)
                continue;

            // Calculate the amount of damage the target should take based on it's distance from the shell.
            float damage = CalculateDamage (targetRigidbody.position);

            // Deal this damage to the tank.
            targetHealth.TakeDamage (damage);

            if (!targetHealth2)
                continue;

            targetHealth2.TakeDamage(damage);
            */

        }

    }
}
