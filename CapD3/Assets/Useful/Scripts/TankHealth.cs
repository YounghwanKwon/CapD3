using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class TankHealth : MonoBehaviour
    {
        public float m_StartingHealth = 100f;              
        public Slider m_Slider;                          
        public Image m_FillImage;                        
        public Color m_FullHealthColor = Color.green;      
        public Color m_ZeroHealthColor = Color.red;      
        public GameObject m_ExplosionPrefab;             
        [SerializeField] private Slider UIHealthslider;
        [SerializeField] private Image UIHealthImage;
        [SerializeField] private GameObject Tmanager;
        private TutorialManagerScript Tmanagerscript;


        private bool deathable = true;
        private AudioSource m_ExplosionAudio;            
        private ParticleSystem m_ExplosionParticles;   
        private float m_CurrentHealth;                  
        private bool m_Dead;                           

        [SerializeField] private GameObject[] Canvass;
        private PauseCanvasScript canvascript1;
        private IngameCanvasScript canvascript2;
        private ButtonCanvasScript1 canvascript3;

        private void Start()
        {
            if(canvascript1 == null)
                canvascript1 = Canvass[0].GetComponent<PauseCanvasScript>();
            if(canvascript2 == null)
                canvascript2 = Canvass[1].GetComponent<IngameCanvasScript>();
            if (canvascript3 == null)
                canvascript3 = Canvass[2].GetComponent<ButtonCanvasScript1>();
            if(Tmanager)
                Tmanagerscript = Tmanager.GetComponent<TutorialManagerScript>();
        }

        private void Awake ()
        {
            m_ExplosionParticles = Instantiate (m_ExplosionPrefab).GetComponent<ParticleSystem> ();

            m_ExplosionAudio = m_ExplosionParticles.GetComponent<AudioSource> ();

            m_ExplosionParticles.gameObject.SetActive (false);
        }


        private void OnEnable()
        {
            m_CurrentHealth = m_StartingHealth;
            m_Dead = false;

            SetHealthUI();
        }


        public void TakeDamage (float amount)
        {
            m_CurrentHealth -= amount;
            if (m_CurrentHealth <= -1)
                m_CurrentHealth = -1;

            SetHealthUI ();
            if(Tmanagerscript)
            {
                deathable = false;
                int i = Tmanagerscript.gettercontine();
                if(i == 2 || i == 3)
                    Tmanagerscript.addcontinue();
            }
            if (m_CurrentHealth <= 0f && !m_Dead)
            {
                OnDeath ();
            }
        }
        public void GetHealing(float amount)
        {
            m_CurrentHealth += amount;
            if (m_CurrentHealth >= 100.0f)
            {
                m_CurrentHealth = 100.0f;
            }
            SetHealthUI();
            if (Tmanagerscript)
            {
                deathable = false;
                int i = Tmanagerscript.gettercontine();
                if (i == 4)
                    Tmanagerscript.addcontinue();
            }
        }

        private void SetHealthUI ()
        {
            m_Slider.value = m_CurrentHealth;
            UIHealthslider.value = m_CurrentHealth;

            m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
            UIHealthImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);

        }


        private void OnDeath ()
        {
            if(deathable == true)
            {
                Time.timeScale = 0;
                m_Dead = true;

                m_ExplosionParticles.transform.position = transform.position;
                m_ExplosionParticles.gameObject.SetActive (true);

                m_ExplosionParticles.Play ();

                m_ExplosionAudio.Play();

                gameObject.SetActive (false);
                gameend();
                }
        }
        public void fullrecovery()
        {
            m_CurrentHealth = 100;
            SetHealthUI();
        }

        public void gameend()
        {
            canvascript1.whenuserdead();
            canvascript2.whenuserdead();
            canvascript3.whenuserdead();
        }

    }
}