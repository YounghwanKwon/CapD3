using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NWmanagerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] hammers;
    [SerializeField] private GameObject[] boss;
    private bool alive1;
    private bool alive2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hammers.Length; i++)
            hammers[i].SetActive(true);
        for (int i = 0; i < boss.Length; i++)
            boss[i].SetActive(true);
        alive1 = true;
        alive2 = true;
    }
    public void setdisactive1()
    {
        alive1 = false;
        checkplayerwinNW();
    }
    public void setdisactive2()
    {
        alive2 = false;
        checkplayerwinNW();
    }
    public void checkplayerwinNW()
    {
        if(!alive1 && !alive2)
        {
            Debug.Log("UI player win need");
        }
        else
            Debug.Log("not enough : "+alive1 +" "+ alive2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
