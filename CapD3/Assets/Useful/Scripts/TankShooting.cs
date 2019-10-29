using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class TankShooting : MonoBehaviour
    {
        public int m_PlayerNumber = 1;              
        public Rigidbody m_Shell;                 
        public Transform m_FireTransform;          
        public Slider m_AimSlider;                  
        public AudioSource m_ShootingAudio;        
        public AudioClip m_ChargingClip;           
        public AudioClip m_FireClip;               
        public float m_MinLaunchForce = 15f;      
        public float m_MaxLaunchForce = 30f;        
        public float m_MaxChargeTime = 0.75f;     
        [SerializeField] private int m_MaxBullet = 20;
        [SerializeField] private Text LastBullet;
        [SerializeField] private GameObject Tmanager;
        private TutorialManagerScript Tmanagerscript;

        private int m_CurrentBullet;
        private string m_FireButton;               
        private float m_CurrentLaunchForce;       
        private float m_ChargeSpeed;              
        private bool m_Fired;                    


        private void OnEnable()
        {
            m_CurrentLaunchForce = m_MinLaunchForce;
            m_AimSlider.value = m_MinLaunchForce;
        }


        private void Start ()
        {
            btnctrlfire.pressed = false;
            btnctrlfire.crntBtn = 0;
            btnctrlfire.firebtn = 0;
            refillbullet();
            addbullet();
        
            m_FireButton = "Fire" + m_PlayerNumber;

            m_ChargeSpeed = (m_MaxLaunchForce - m_MinLaunchForce) / m_MaxChargeTime;
            LastBullet.text = "Lasting bullet: "+m_CurrentBullet;

            if (Tmanager)
            {
                Tmanagerscript = Tmanager.GetComponent<TutorialManagerScript>();
            }

        }


        private void Update ()
        {
            if(m_CurrentBullet > 0)
            {
                m_AimSlider.value = m_MinLaunchForce;
                if (btnctrlfire.pressed == true && !m_Fired)
                {
                    m_CurrentLaunchForce += m_ChargeSpeed * Time.deltaTime;
                    m_AimSlider.value = m_CurrentLaunchForce;
                    if (m_CurrentLaunchForce >= m_MaxLaunchForce)
                    {
                        m_CurrentLaunchForce = m_MaxLaunchForce;
                        Fire();
                    }
                    
                }
                if (btnctrlfire.pressed==false && m_CurrentLaunchForce != m_MinLaunchForce)
                {
                    Fire();
                }
            }
        }


        private void Fire ()
        {
            m_Fired = true;

            Rigidbody shellInstance =
                Instantiate (m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

            shellInstance.velocity = m_CurrentLaunchForce * m_FireTransform.forward; 

            m_ShootingAudio.clip = m_FireClip;
            m_ShootingAudio.Play ();

            m_CurrentLaunchForce = m_MinLaunchForce;
            m_CurrentBullet -= 1;
            Debug.Log("사격 후 남은 총알 수: " + m_CurrentBullet);
            SetUIBulletCount();
            m_Fired = false;
            if (Tmanager)
            {
                int i = Tmanagerscript.gettercontine();
                if(i == 6)
                {
                    Tmanagerscript.addcontinue();
                }
                m_CurrentBullet = m_MaxBullet;
            }
        }

        public void refillbullet()
        {
            m_CurrentBullet = m_MaxBullet;
            Debug.Log("현재 총알 수: " + m_CurrentBullet);
            SetUIBulletCount();
        }
        public void SetUIBulletCount()
        {
            LastBullet.text = "Lasting bullet: " + m_CurrentBullet;
        }
        public void addbullet()
        {
            m_CurrentBullet++;
            if (m_CurrentBullet > m_MaxBullet)
            {
                m_CurrentBullet = m_MaxBullet;
            }
            SetUIBulletCount();
            Invoke("addbullet", 3);
        }
    }
}