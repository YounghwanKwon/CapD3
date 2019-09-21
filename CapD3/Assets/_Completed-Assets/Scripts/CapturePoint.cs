using System.Collections;
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
    [SerializeField] private GameObject test1;
    [SerializeField] private GameObject resetbtn;

    private bool onlyone = false;
    private bool Istotallycaptured = false;
    private DateTime OneSecLater;
    private TimeSpan span;
    // Start is called before the first frame update

    void tryCapturing()
    {
        if (count < 20000.0d && capturing == true)
        {
            //howfarvec = new Vector3(Mathf.Abs(tank.transform.position.x - CapturePointPos.transform.position.x), 0, Mathf.Abs(tank.transform.position.z - CapturePointPos.transform.position.z));
            tryaddcount();
            
            if(count - 10000 >= tencheck)
            {
                Debug.Log("count: " + count + " tencheck: " + tencheck+" howfarvec: " +howfarvec);
                tencheck += 10000;
            }
            distancecheck();
        }
        if (count >= 20000.0d ) 
        {
            Istotallycaptured = true;
            if (onlyone == false)
            {
                Debug.Log("20초가지남 count: " + count);
                test1.SetActive(true);
                Invoke("deactive", 5);
                onlyone = true;
            }

        }
        else if (capturing == false)
        {
            Debug.Log("too far to capture");
        }
        else
            Debug.Log("ㅈ됨;;");
        Debug.Log("end tryCapturing");
    }
    void deactive()
    {
        test1.SetActive(false);
        resetbtn.SetActive(true);
    }

    void tryaddcount()
    {
        Invoke("OneSeclaterfunc", 0);
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
        span = TimeSpan.Zero;
        now = DateTime.Now;
        //capturing = false;
        

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (capturing == false && Istotallycaptured == false)
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
