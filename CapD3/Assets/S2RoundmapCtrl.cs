using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2RoundmapCtrl : MonoBehaviour
{
    public GameObject RG1;
    public GameObject RG2;
    public GameObject RG3;
    public GameObject RG4;
    public GameObject RG5;
    public GameObject cube2;

    // Start is called before the first frame update
    void Start()
    {
        cube2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        MapChange();
    }
    void MapChange()
    {
        if (TimeSetting.timeset == 1)
        {
            RG1.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (TimeSetting.timeset == 2)
        {
            RG1.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (TimeSetting.timeset == 3)
        {
            RG1.GetComponent<MeshRenderer>().material.color = Color.white;
            RG1.SetActive(false);
            RG2.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (TimeSetting.timeset == 4)
        {
            RG2.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (TimeSetting.timeset == 5)
        {
            RG2.GetComponent<MeshRenderer>().material.color = Color.white;
            RG2.SetActive(false);
            RG3.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (TimeSetting.timeset == 6)
        {
            RG3.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (TimeSetting.timeset == 7)
        {
            RG3.GetComponent<MeshRenderer>().material.color = Color.white;
            RG3.SetActive(false);
            RG4.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (TimeSetting.timeset == 8)
        {            
            RG4.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (TimeSetting.timeset == 9)
        {
            RG4.GetComponent<MeshRenderer>().material.color = Color.white;
            RG4.SetActive(false);
            RG5.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (TimeSetting.timeset == 10)
        {
            RG5.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (TimeSetting.timeset == 11)
        {
            RG5.GetComponent<MeshRenderer>().material.color = Color.white;
            RG5.SetActive(false);            
        }
        else
        {
            Debug.Log("에러남");
        }
    }
}
