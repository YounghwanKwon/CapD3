using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChangeO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
