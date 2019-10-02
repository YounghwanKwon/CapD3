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

    // Start is called before the first frame update
    void Start()
    {
        bosshpslider.gameObject.SetActive(true);
        CurrentHPcount = MaxHPcount;
        bosshpslider.value = CurrentHPcount;
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
        if (!m_Dead)
        {
            Transform nT = new GameObject().transform;
            for(int i=-3;i<4;i+=6)
                for(int j=-3;j<4;j+=6)
                {
                    nT.position = new Vector3(transform.position.x+i, transform.position.y, transform.position.z+j);
                    GameObject pet = Instantiate(summonedobj, nT);
                    Debug.Log("summon");
                    pet.SetActive(true);
                    pet.transform.parent = null;
                }
            Invoke("summon", 5);
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
