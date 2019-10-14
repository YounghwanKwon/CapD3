﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingForTurret : MonoBehaviour
{
    [SerializeField] private GameObject objecttank;

    public int m_PlayerNumber = 1;              // Used to identify the different players.
    public Rigidbody m_Shell;                   // Prefab of the shell.
    public Transform m_FireTransform;           // A child of the tank where the shells are spawned.
    //public Slider m_AimSlider;                  // A child of the tank that displays the current launch force.
    public AudioSource m_ShootingAudio;         // Reference to the audio source used to play the shooting audio. NB: different to the movement audio source.
    public AudioClip m_ChargingClip;            // Audio that plays when each shot is charging up.
    public AudioClip m_FireClip;                // Audio that plays when each shot is fired.
    public float m_MinLaunchForce = 30f;        // The force given to the shell if the fire button is not held.
    public float m_MaxLaunchForce = 60f;        // The force given to the shell if the fire button is held for the max charge time.
    public float m_MaxChargeTime = 0.75f;       // How long the shell can charge for before it is fired at max force.
    [SerializeField] private int m_MaxBullet = 20;
    //[SerializeField] private Text LastBullet;

    private int m_CurrentBullet;
    private string m_FireButton;                // The input axis that is used for launching shells.
    private float m_CurrentLaunchForce=15.0f;         // The force that will be given to the shell when the fire button is released.
    private float m_ChargeSpeed;                // How fast the launch force increases, based on the max charge time.
    private bool m_Fired;                       // Whether or not the shell has been launched with this button press.
    private bool wait = false;
                                                // Start is called before the first frame update
    public void TurretFire()
    {
        if (gameObject.activeSelf)
        {
            // Set the fired flag so only Fire is only called once.
            m_Fired = true;

            // Create an instance of the shell and store a reference to it's rigidbody.
            Rigidbody shellInstance =
                Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

            // Set the shell's velocity to the launch force in the fire position's forward direction.
            shellInstance.velocity = m_CurrentLaunchForce * m_FireTransform.forward;

            // Change the clip to the firing clip and play it.
            m_ShootingAudio.clip = m_FireClip;
            m_ShootingAudio.Play();

            // Reset the launch force.  This is a precaution in case of missing button events.
            m_CurrentLaunchForce = m_MinLaunchForce;
            Invoke("TurretFire", 2.667f);
        }
        
    }

    void Start()
    {
        Invoke("TurretFire", 1.65f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
