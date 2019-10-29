using System.Collections;
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

    private AudioSource m_ExplosionAudio;               
    private ParticleSystem m_ExplosionParticles;    
    private float m_CurrentHealth;                    
    private bool m_Dead;                            


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

    public void LTurretDamage()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, lazerdistance))
        {
            ScaleDistance.transform.localScale = new Vector3(1, hit.distance, 1);

            RayResult.transform.position = hit.point;

            RayResult.transform.rotation = Quaternion.LookRotation(hit.normal);
            if (hit.point != null)
            {
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
    }

    private void OnDeath()
    {
        m_Dead = true;
        TankObj.SetActive(false);
        ResetBtn.SetActive(true);
        SSBtn.SetActive(true);
    }
}

