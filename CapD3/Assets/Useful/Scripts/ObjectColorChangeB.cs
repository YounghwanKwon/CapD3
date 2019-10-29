using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChangeB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
