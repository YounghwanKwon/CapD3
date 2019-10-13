using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakableWallScript : MonoBehaviour
{
    [SerializeField] private int MaxHPcount;
    [SerializeField] private GameObject deadparticle;
    [SerializeField] private Slider thisslider;
    private int CurrentHPcount;
    private bool m_Dead = false;
    [SerializeField] private GameObject Tmanager;
    private TutorialManagerScript Tmanagerscript;
    [SerializeField] private GameObject NWmanager;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHPcount = MaxHPcount;
        if(thisslider)
            thisslider.gameObject.SetActive(true);
        setUIHP();
    }
    public void TakeDamage(int i)
    {
        Debug.Log("take damaged : " + this);
        CurrentHPcount -= i;
        setUIHP();
        if (Tmanager)
        {
            CurrentHPcount = MaxHPcount;
        }
        if (CurrentHPcount <= 0 && m_Dead == false)
        {
            OnDeath();
        }
    }
    public void setUIHP()
    {
        if (thisslider)
        {
            thisslider.value = CurrentHPcount;
        }
    }
    private void OnDeath()
    {
        if (this.gameObject.CompareTag("golem1") && NWmanager)
        {
            NWmanagerScript nwscript = NWmanager.GetComponent<NWmanagerScript>();
            nwscript.setdisactive1();
        }
        else if (this.gameObject.CompareTag("golem2") && NWmanager)
        {
            NWmanagerScript nwscript = NWmanager.GetComponent<NWmanagerScript>();
            nwscript.setdisactive2();
        }
        m_Dead = true;
        GameObject thisparticle = Instantiate(deadparticle, transform);
        thisparticle.SetActive(true);
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
