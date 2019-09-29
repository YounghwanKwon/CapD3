using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWallScript : MonoBehaviour
{
    [SerializeField] private int MaxHPcount;
    [SerializeField] private GameObject deadparticle;
    private int CurrentHPcount;
    private bool m_Dead = false;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHPcount = MaxHPcount;
    }
    public void TakeDamage(int i)
    {
        CurrentHPcount -= i;
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
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
