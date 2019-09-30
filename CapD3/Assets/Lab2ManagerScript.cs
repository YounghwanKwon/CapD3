using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab2ManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject shell1;
    [SerializeField] private Transform BombPlacingPoint1;
    // Start is called before the first frame update
    void Start()
    {
        DropA();
    }
    void DropA()
    {
        Instantiate(shell1, BombPlacingPoint1);
        //Instantiate(shell1,new Vector3(0,0.1f,0),Quaternion.Euler(Vector3.zero));
        Invoke("DropA", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
