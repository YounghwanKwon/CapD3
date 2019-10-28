using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1Script : MonoBehaviour
{
    public static int colorset;
    public bool status = false;

    // Start is called before the first frame update
    void Start()
    {
        colorset = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        if(colorset == 0)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if(colorset == 1)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if(colorset == 2)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (colorset == 3)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (colorset == 4)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            if (!status)
            {
                status = true;
                Switch2Script.colorset++;
                Switch5Script.colorset++;
            }
            else if (status)
            { 
                status = false;
                Switch2Script.colorset--;
                Switch5Script.colorset--;
            }
        }
    }
}
