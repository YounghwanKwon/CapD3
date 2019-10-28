using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingHammerCtrl : MonoBehaviour
{
    public GameObject RoundCenter;
    public float QuadrantChk = 0;
    public float xpos;
    public float zpos;
    public bool plmn;
    [SerializeField] private float hammerdownstart;
    [SerializeField] private float hammerupstart;
    [SerializeField] private float waittingstart;
    [SerializeField] private float rotationtime;

    // Start is called before the first frame update
    void Start()
    {
        if (hammerdownstart == 0) hammerdownstart = 0f;
        if (hammerupstart == 0) hammerupstart = 50.0f;
        if (waittingstart == 0) waittingstart = 100.0f;
        if (rotationtime == 0) rotationtime = 400.0f;
        InvokeRepeating("HammerSwing", 0f, 0.01f);
        InvokeRepeating("setpos", 0f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void HammerSwing()
    {
        if (QuadrantChk < hammerdownstart)//대기
        {
            QuadrantChk++;
        }
        else if (QuadrantChk >= hammerdownstart && QuadrantChk < hammerupstart)//망치내림
        {
            QuadrantChk++;
            xpos -= 0.1f;
            float t = (-xpos * -xpos * -1) + 100;
            t = Mathf.Round(t * 10) * 0.1f;
            //Debug.Log("t:" + t + "xpos:" + xpos);
            zpos = Mathf.Sqrt(t);
        }
        
        else if (QuadrantChk >= hammerupstart && QuadrantChk < waittingstart)//망치올림
        {
            QuadrantChk++;
            xpos += 0.1f;
            zpos = Mathf.Sqrt((-xpos * -xpos * -1) + 100);
        }
        else if (QuadrantChk >= waittingstart && QuadrantChk < rotationtime)//대기
        {
            QuadrantChk++;
        }
        else if (QuadrantChk >= rotationtime)//초기화
        {
            QuadrantChk = 0;
        }
    }
    void setpos()
    {
         RoundCenter.transform.rotation = Quaternion.Euler(0, 0, -Mathf.Atan2(xpos, zpos) * Mathf.Rad2Deg); 
    }
}
