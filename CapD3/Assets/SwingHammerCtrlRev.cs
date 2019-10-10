using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingHammerCtrlRev : MonoBehaviour
{
    public GameObject RoundCenter;
    public float QuadrantChk = 0;
    public float xpos;
    public float zpos;
    public bool plmn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HammerSwing", 0f, 0.02f);
        InvokeRepeating("setpos", 0f, 0.02f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void HammerSwing()
    {
        if (QuadrantChk < 400)
        {
            QuadrantChk++;
        }
        else if (QuadrantChk >= 400 && QuadrantChk < 500)
        {
            QuadrantChk++;
            xpos -= 0.1f;
            zpos = Mathf.Sqrt((-xpos * -xpos * -1) + 100);
        }
        else if (QuadrantChk >= 500 && QuadrantChk < 600)
        {
            QuadrantChk++;
            xpos += 0.1f;
            zpos = Mathf.Sqrt((-xpos * -xpos * -1) + 100);
        }
        else if (QuadrantChk >= 600 && QuadrantChk < 800)
        {
            QuadrantChk++;
        }
        else if (QuadrantChk >= 800)
        {
            QuadrantChk = 0;
        }
    }
    void setpos()
    {
        RoundCenter.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(xpos, zpos) * Mathf.Rad2Deg);
    }
}

