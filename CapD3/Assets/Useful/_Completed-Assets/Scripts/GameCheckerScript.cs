using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheckerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] tankforstage;
    [SerializeField] private Transform[] SpwanPoint;
    public int stagenumber;
    public bool isgoing = false;


    // Start is called before the first frame update
    public void setisgoingture()
    {
        isgoing = true;
    }
    public void setisgoingfalse()
    {
        isgoing = false;
    }
    public void respwantank()
    {
        Instantiate(tankforstage[stagenumber-1], SpwanPoint[stagenumber-1]);
    }
    public void setstagenumber1()
    {
        stagenumber = 1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
