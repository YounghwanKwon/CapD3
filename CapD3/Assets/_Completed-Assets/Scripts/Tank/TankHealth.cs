using UnityEngine;
using UnityEngine.UI;

namespace Complete
{
    public class TankHealth : MonoBehaviour
    {
        public float m_StartingHealth = 100f;               // The amount of health each tank starts with.
        public Slider m_Slider;                             // The slider to represent how much health the tank currently has.
        public Image m_FillImage;                           // The image component of the slider.
        public Color m_FullHealthColor = Color.green;       // The color the health bar will be when on full health.
        public Color m_ZeroHealthColor = Color.red;         // The color the health bar will be when on no health.
        public GameObject m_ExplosionPrefab;                // A prefab that will be instantiated in Awake, then used whenever the tank dies.
        [SerializeField] private Slider UIHealthslider;
        [SerializeField] private Image UIHealthImage;
        [SerializeField] private GameObject Tmanager;
        private TutorialManagerScript Tmanagerscript;


        private bool deathable = true;
        private AudioSource m_ExplosionAudio;               // The audio source to play when the tank explodes.
        private ParticleSystem m_ExplosionParticles;        // The particle system the will play when the tank is destroyed.
        private float m_CurrentHealth;                      // How much health the tank currently has.
        private bool m_Dead;                                // Has the tank been reduced beyond zero health yet?

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
            // Instantiate the explosion prefab and get a reference to the particle system on it.
            m_ExplosionParticles = Instantiate (m_ExplosionPrefab).GetComponent<ParticleSystem> ();

            // Get a reference to the audio source on the instantiated prefab.
            m_ExplosionAudio = m_ExplosionParticles.GetComponent<AudioSource> ();

            // Disable the prefab so it can be activated when it's required.
            m_ExplosionParticles.gameObject.SetActive (false);
        }


        private void OnEnable()
        {
            // When the tank is enabled, reset the tank's health and whether or not it's dead.
            m_CurrentHealth = m_StartingHealth;
            m_Dead = false;

            // Update the health slider's value and color.
            SetHealthUI();
        }


        public void TakeDamage (float amount)
        {
            // Reduce current health by the amount of damage done.
            m_CurrentHealth -= amount;
            Debug.Log("현재 체력: " + m_CurrentHealth);
            if (m_CurrentHealth <= -1)
                m_CurrentHealth = -1;

            // Change the UI elements appropriately.
            SetHealthUI ();
            if(Tmanagerscript)
            {
                deathable = false;
                int i = Tmanagerscript.gettercontine();
                if(i == 2 || i == 3)
                    Tmanagerscript.addcontinue();
            }


            // If the current health is at or below zero and it has not yet been registered, call OnDeath.
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
            // Set the slider's value appropriately.
            m_Slider.value = m_CurrentHealth;
            UIHealthslider.value = m_CurrentHealth;

            // Interpolate the color of the bar between the choosen colours based on the current percentage of the starting health.
            m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
            UIHealthImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);

        }


        private void OnDeath ()
        {
            if(deathable == true)
            {
                Time.timeScale = 0;
                // Set the flag so that this function is only called once.
                m_Dead = true;

                // Move the instantiated explosion prefab to the tank's position and turn it on.
                m_ExplosionParticles.transform.position = transform.position;
                m_ExplosionParticles.gameObject.SetActive (true);

                // Play the particle system of the tank exploding.
                m_ExplosionParticles.Play ();

                // Play the tank explosion sound effect.
                m_ExplosionAudio.Play();

                // Turn the tank off.
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