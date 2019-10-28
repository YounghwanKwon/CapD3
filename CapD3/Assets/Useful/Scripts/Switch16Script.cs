using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch16Script : MonoBehaviour
{
    public static int colorset;
    public bool status = false;
    void Start()
    {
        colorset = 0;
    }

    void Update()
    {
        if (colorset == 0)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (colorset == 1)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (colorset == 2)
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
                Switch12Script.colorset++;
                Switch15Script.colorset++;
            }
            else if (status)
            {
                status = false;
                Switch12Script.colorset--;
                Switch15Script.colorset--;
            }
        }
    }
}
