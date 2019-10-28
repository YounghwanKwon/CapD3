using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmove2 : MonoBehaviour
{

    CharacterController controller;
    public float speed = 10;
    float verticalVelocity;
    public Camera cam;

    private float rotLeftRight;
    private float rotUpDown;
    private float verticalRotation = 0f;
    public float movementSpeed = 5f;
    public float Sensitivity = 2f;
    public float upDownRange = 90;



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       // float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
       // float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float y = -9.8f;

        Vector3 moveDelta = new Vector3(0, y, 0);
        //controller.Move(moveDelta);
        FPRotate();
    }

    void FPRotate()
    {

        //좌우 회전
        if (btnctrlrr.moveforr == 1)
        {
            rotLeftRight = btnctrlrr.moveforr * Sensitivity;
        }
        else
        {
            rotLeftRight = btnctrlll.moveforl * Sensitivity;
        }
        transform.Rotate(0f, rotLeftRight, 0f);

        Vector3 dir = cam.transform.localRotation * Vector3.forward;

        if (btnctrlf.movefor == 1)
        {
            gameObject.transform.Translate(btnctrlf.movefor * dir * 5f * Time.deltaTime);
        }
        else
        {
            gameObject.transform.Translate(btnctrlb.moveforb * dir * 5f * Time.deltaTime);
        }
    }
}
