using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundMove : MonoBehaviour
{
    public GameObject Roundmove1;
    public GameObject RoundCenter;
    //public float count = 0;
    public float QuadrantChk = 0;
    public Vector3 movement = new Vector3(0f, 1.25f, 0f);
    public float xpos;
    public float zpos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("movementstart", 0f, 0.01f);
        InvokeRepeating("setpos", 0f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void setpos()
    {
        Roundmove1.transform.position = movement;
        Roundmove1.transform.rotation = Quaternion.Euler(0, Mathf.Atan2(xpos, zpos) * Mathf.Rad2Deg + 180, 0);
    }
    void movementstart()
    {
        if (QuadrantChk < 300)
        {
            QuadrantChk++;
            xpos += 0.1f;
            zpos = Mathf.Sqrt((-xpos * -xpos * -1) + 900);
            movement = RoundCenter.transform.position;
            movement.x += xpos;
            movement.z += zpos;         

        }
        if (QuadrantChk >= 300 && QuadrantChk < 600)
        {
            QuadrantChk++;
            xpos -= 0.1f;
            zpos = -1 * Mathf.Sqrt((-xpos * -xpos * -1) + 900);          
            movement = RoundCenter.transform.position;
            movement.x += xpos;
            movement.z += zpos;
        }
        if (QuadrantChk >= 600 && QuadrantChk < 900)
        {
            QuadrantChk++;
            xpos -= 0.1f;
            zpos = -1 * Mathf.Sqrt ((-xpos * -xpos * -1) + 900);
            movement = RoundCenter.transform.position;
            movement.x += xpos;
            movement.z += zpos;
        }
        if (QuadrantChk >= 900 && QuadrantChk < 1200)
        {
            QuadrantChk++;
            xpos += 0.1f;
            zpos = Mathf.Sqrt(((-xpos * -xpos * -1) + 900));
            movement = RoundCenter.transform.position;
            movement.x += xpos;
            movement.z += zpos;
        }
        if(QuadrantChk>=1200)
        {
            QuadrantChk = 0;
        }
    }
}
