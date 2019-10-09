﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_Raycast_Laser : MonoBehaviour {
    
    //2#
    public GameObject Raybody; //레이캐스팅을 쏘는 위치
    public GameObject ScaleDistance; //거리에 따른 스케일 변화를 위한 오브젝트 대상
    public GameObject RayResult; //충돌하는 위치에 출력할 결과
    public GameObject TankObj;
    public GameObject ResetBtn;
    public GameObject SSBtn;

    private AudioSource m_ExplosionAudio;               // The audio source to play when the tank explodes.
    private ParticleSystem m_ExplosionParticles;        // The particle system the will play when the tank is destroyed.
    private float m_CurrentHealth;                      // How much health the tank currently has.
    private bool m_Dead;                                // Has the tank been reduced beyond zero health yet?


    [SerializeField] private GameObject[] Canvass;
    private PauseCanvasScript canvascript1;
    private IngameCanvasScript canvascript2;
    private ButtonCanvasScript1 canvascript3;
    private Rigidbody target;
    private GameObject targetgameobj;
    private Complete.TankHealth targetHealth;
    [SerializeField] private GameObject Tmanager;
    private TutorialManagerScript Tmanagerscript;
    [SerializeField] private float lazerdistance;
    [SerializeField] private float lazerdamagef;

    // Use this for initialization
    void Start () {
        if (Tmanager)
        {
            Tmanagerscript = Tmanager.GetComponent<TutorialManagerScript>();
        }
        InvokeRepeating("LTurretDamage", 0f, 0.01f);
        if (lazerdistance == 0)
            lazerdistance = 200.0f;
        if (lazerdamagef == 0)
            lazerdamagef = 0.3f;
    }
	
    // Update is called once per frame
    void Update () {


    }

    public void LTurretDamage()
    {
        //레이캐스팅 결과정보 저장
        RaycastHit hit;

        //레이캐스트 위치, 방향, 결과값, 최대인식거리
        //Physics.Raycast(transform.position, transform.forward, out hit, 200);
        if (Physics.Raycast(transform.position, transform.forward, out hit, lazerdistance))
        {
            ScaleDistance.transform.localScale = new Vector3(1, hit.distance, 1);

            //레이캐스트가 닿은 곳으로 오브젝트를 옮김
            RayResult.transform.position = hit.point;

            //오브젝트의 회전값을 닿은 면적의 노멀방향와 일치
            RayResult.transform.rotation = Quaternion.LookRotation(hit.normal);
            if (hit.point != null)
            {
                //Debug.Log("hit point not null");
                target = hit.transform.GetComponent<Rigidbody>();
            }

            if (target)
            {
                targetHealth = target.GetComponent<Complete.TankHealth>();
                if (targetHealth)
                    targetHealth.TakeDamage(lazerdamagef);
                if (Tmanager)
                {
                    int i = Tmanagerscript.gettercontine();
                    if (i == 14)
                    {
                        Tmanagerscript.addcontinue();
                    }
                }
            }
        }
        else
        {
            //Debug.Log("hit point null");
        }
    }

    private void OnDeath()
    {

        // Set the flag so that this function is only called once.

        m_Dead = true;



        TankObj.SetActive(false);
        //Time.timeScale = 0;
        ResetBtn.SetActive(true);
        SSBtn.SetActive(true);
    }


}

