﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CapturePoint : MonoBehaviour
{
    [SerializeField] private double count=0d;
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
        if (count < 30000.0d && capturing == true)
        {
            //howfarvec = new Vector3(Mathf.Abs(tank.transform.position.x - CapturePointPos.transform.position.x), 0, Mathf.Abs(tank.transform.position.z - CapturePointPos.transform.position.z));
            tryaddcount();
            
            if(count >= tencheck)
            {
                Debug.Log("count: " + count + " tencheck: " + tencheck+" howfarvec: " +howfarvec);
                tencheck += 10000;
            }
            distancecheck();
        }
        if (count >= 30000.0d)
        {
            Debug.Log("30초가지남 count: "+ count);
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
        Debug.Log("span.totalSeconds: " + span.TotalSeconds);
        Debug.Log("span.TotalMilliseconds: " + span.TotalMilliseconds);
        count += span.TotalMilliseconds;
        Debug.Log("count: " + count);
        capturing = false;
        

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
                now = DateTime.Now;
            }
        }
        else
            capturing = false;
    }
}
