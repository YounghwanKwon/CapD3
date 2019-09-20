using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CapturePoint : MonoBehaviour
{
    [SerializeField] private float count=0f;
    [SerializeField] public int tencheck = 0;
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform CapturePointPos;
    [SerializeField] private Vector3 howfarvec;
    [SerializeField] private float howfar;
    [SerializeField] private bool capturing = false;
    [SerializeField] private DateTime now;

    private DateTime OneSecLater;
    private TimeSpan span;
    // Start is called before the first frame update

    void tryCapturing()
    {
        if (count < 30000.0f && capturing == true)
        {
            //howfarvec = new Vector3(Mathf.Abs(tank.transform.position.x - CapturePointPos.transform.position.x), 0, Mathf.Abs(tank.transform.position.z - CapturePointPos.transform.position.z));
            tryaddcount();
            
            if(count >= tencheck)
            {
                Debug.Log("count: " + count + " tencheck: " + tencheck+" howfarvec: " +howfarvec);
                tencheck += 10;
            }
            distancecheck();
        }
        if (count >= 30f)
        {
            Debug.Log("30초가지남");
        }
        else if (capturing == false)
        {
            Debug.Log("too far to capture");
        }
        else
            Debug.Log("ㅈ됨;;");
        Debug.Log("end tryCapturing");
    }

    void tryaddcount()
    {
        now = DateTime.Now;
        Debug.Log("now: " + now);
        Debug.Log("now.tolocaltime: " + now.ToLocalTime());
        Invoke("OneSeclaterfunc", 1);
        //Debug.Log("now.tolocaltime: " + now.ToLocalTime());
        /*TimeSpan span = DateTime.Now.ToLocalTime() - now.ToLocalTime();
        while (span.TotalSeconds <= 1)
        {
            span = DateTime.Now.ToLocalTime() - now.ToLocalTime();
        }
        if (capturing == true)
            count++;*/
    }
    void OneSeclaterfunc()
    {
        OneSecLater = DateTime.Now;
        span = OneSecLater - now;
        Debug.Log("span: " + span.TotalSeconds);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (capturing == false)
            distancecheck();
        else
            tryCapturing();
    }

    void distancecheck()
    {
        if (Vector3.Distance(CapturePointPos.transform.position, tank.transform.position) <= 5.0f)
        {
            if (capturing == false)
            {
                capturing = true;
            }
        }
        else
            capturing = false;
    }
}
