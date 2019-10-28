using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summonctrl : MonoBehaviour
{
    [SerializeField] private GameObject summonedobj;
    private bool need = true;
    [SerializeField] private int i = 60;
    [SerializeField] private GameObject[] triggercube;
    private int max,rotationnum;
    [SerializeField] private GameObject ToNWcube;
    [SerializeField] private GameObject OildStorage;
    [SerializeField] private GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        max = triggercube.Length;
        Invoke("Summon", 0f);
        Invoke("ToNWcubefunc", 35);
    }
    public void ToNWcubefunc()
    {
        OildStorage.SetActive(false);
        ToNWcube.SetActive(true);
        slider.SetActive(false);
    }
    public void needfalsefy()
    {
        need = false;
    }
    
    void Summon()
    {
        if(need == true)
        {
            i--;
            Transform SummonPoint = new GameObject().transform;
            SummonPoint.position = triggercube[rotationnum].transform.position;
            GameObject Bomb = Instantiate(summonedobj, SummonPoint);
            Bomb.SetActive(true);
            Bomb.transform.parent = null;
            rotatenum();
            Invoke("Summon", 0.5f);
        }
        checki();
    }
    void rotatenum()
    {
        rotationnum++;
        rotationnum %= max;
    }
    void checki()
    {
        if (i <= 0 && need == true)
        {
            needfalsefy();
        }
    }
}
