using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dronebossScript : MonoBehaviour
{
    [SerializeField] private int MaxHPcount;
    [SerializeField] private GameObject deadparticle;
    private int CurrentHPcount;
    private bool m_Dead = false;
    [SerializeField] private GameObject Tmanager;
    private TutorialManagerScript Tmanagerscript;
    [SerializeField] private GameObject coreobj;
    [SerializeField] private Slider bosshpslider;
    [SerializeField] private GameObject summonedobj;
    [SerializeField] private GameObject s1manager;
    [SerializeField] private GameObject s1HDMDmanager;
    [SerializeField] private GameObject zerovec;
    private Transform nT;
    private float i = -17.5f, j =-17.5f;
    private int rotation;

    // Start is called before the first frame update
    void Start()
    {
        bosshpslider.gameObject.SetActive(true);
        CurrentHPcount = MaxHPcount;
        bosshpslider.value = CurrentHPcount;
        rotation = 0;
        summon();
    }
    public void TakeDamage(int i)
    {
        CurrentHPcount -= i;
        bosshpslider.value = CurrentHPcount;
        if (Tmanager)
        {
            CurrentHPcount = MaxHPcount;
        }
        if (CurrentHPcount <= 0 && m_Dead == false)
        {
            OnDeath();
        }
    }

    private void OnDeath()
    {
        m_Dead = true;
        GameObject thisparticle = Instantiate(deadparticle, transform);
        thisparticle.SetActive(true);
        coreobj.transform.position = this.transform.position;
        coreobj.SetActive(true);
        bosshpslider.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
    private void summon()
    {
        if (!m_Dead && s1manager)
        {

            Transform nT = new GameObject().transform;
            for (int i = -3; i < 4; i += 6)
                for (int j = -3; j < 4; j += 6)
                {
                    nT.position = new Vector3(transform.position.x + i, transform.position.y, transform.position.z + j);
                    GameObject pet = Instantiate(summonedobj, nT);
                    pet.SetActive(true);
                    pet.transform.parent = null;
                }
            Invoke("summon", 5);
        }
        else if (!m_Dead && s1HDMDmanager) {
            
            setij();
            zerovec.transform.position = new Vector3(zerovec.transform.position.x + i,zerovec.transform.position.y, zerovec.transform.position.z + j);
            GameObject pet = Instantiate(summonedobj,zerovec.transform);
            pet.SetActive(true);
            MovementE ME = pet.GetComponent<MovementE>();
            ME.poweronfunc();
            pet.transform.parent = null;
            zerovec.transform.position = Vector3.zero;
            Invoke("summon", 2.5f);
        }
        
    }
    private void setij()
    {
        rotation++;
        if(rotation %4 == 0) { i = 5.0f; j = 0; }
        else if (rotation % 4 == 1) { i = 0; j = 5.0f; }
        else if (rotation % 4 == 2) { i = -5.0f; j = 0; }
        else { i = 0; j = -5.0f; }
    }
}
