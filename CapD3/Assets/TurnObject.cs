using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnObject : MonoBehaviour
{
    public GameObject Lturret;
    public Vector3 RotVec;
    public Vector3 RotSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        RotSpeed = new Vector3(0, 1f, 0);
        InvokeRepeating("ObjectTurn", 0f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ObjectTurn()
    {
        RotVec += RotSpeed;
        Lturret.transform.rotation = Quaternion.Euler(RotVec);
    }
}
