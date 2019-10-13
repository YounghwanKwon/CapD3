using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summonctrl : MonoBehaviour
{
    [SerializeField] private GameObject summonedobj;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Summon", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Summon()
    {
        Transform SummonPoint = new GameObject().transform;
        //Debug.Log(SummonPoint.transform.position);
        SummonPoint.position = this.transform.position;
        //Debug.Log(SummonPoint.transform.position);
        GameObject Bomb = Instantiate(summonedobj, SummonPoint);
        //Debug.Log("소환");
        Bomb.SetActive(true);
        Bomb.transform.parent = null;
    }
}
