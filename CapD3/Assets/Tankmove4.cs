using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankmove4 : MonoBehaviour
{
    public Joystick joystick;
    Rigidbody rigidbody1;

    void awake()
    {
        rigidbody1 = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        rigidbody1.velocity = new Vector3(joystick.Horizontal * 100f, rigidbody1.velocity.y, joystick.Vertical * 100f);
    }
}
