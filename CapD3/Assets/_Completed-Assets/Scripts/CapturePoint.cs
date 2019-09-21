using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CapturePoint : MonoBehaviour
{
    [SerializeField] private float count=0.0f;
    [SerializeField] public int tencheck = 0;
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform CapturePointPos;
    [SerializeField] private float howfar;
    [SerializeField] private bool capturing = false;
    [SerializeField] private DateTime now;
    [SerializeField] private GameObject test1;
    [SerializeField] private GameObject resetbtn;
    [SerializeField] private GameObject timer;
    [SerializeField] private Slider UICapturingSlider;

    private float realtimer = 0.0f;
    private bool onlyone = false;
    private bool Istotallycaptured = false;
    private DateTime OneSecLater;
    private TimeSpan span;
    // Start is called before the first frame update

    void tryCapturing()
    {
        if (count < 15.0f && capturing == true)
        {
            tryaddcount();
            
            if(count - 1.0f >= tencheck)
            {
                Debug.Log("count: " + count + " tencheck: " + tencheck);
                tencheck += 1;
            }
            distancecheck();
        }
        if (count >= 15.0f)
        {
            Istotallycaptured = true;
            if (onlyone == false)
            {
                Debug.Log("15초가지남 count: " + count);
                test1.SetActive(true);
                TimerScript temptimer = timer.GetComponent<TimerScript>();
                temptimer.timepassoff();

                Invoke("deactive", 5);
                onlyone = true;
            }

        }
        else if (capturing == false)
        {
            Debug.Log("too far to capture");
        }
        else if (capturing == true) { Debug.Log("정상"); }
        else
            Debug.Log("ㅈ됨;;count : "+ count);
        Debug.Log("end tryCapturing  count : " + count);
    }
    void deactive()
    {
        test1.SetActive(false);
        resetbtn.SetActive(true);
    }
    public void CPreset()
    {
        count = 0; SetUICapturingSlider();
         tencheck = 0;
        onlyone = false;
        Istotallycaptured = false;
        Invoke("countreset", 1);
    }

    void countreset()
    {
        count = 0; SetUICapturingSlider();
        Debug.Log("count: " + count);
    }
    void tryaddcount()
    {
        //float temp = 0;
        //temp += Time.deltaTime;
        //count += Mathf.Round(temp * 10) * 0.1f;

        count += Time.deltaTime;
        SetUICapturingSlider();
        Debug.Log("count: " + count);


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
        //count += span.TotalMilliseconds;
        
        Debug.Log("count: " + count);
        span = TimeSpan.Zero;
        now = DateTime.Now;
        //capturing = false;
        

    }
    void Start()
    {
        SetUICapturingSlider();
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

    void SetUICapturingSlider()
    {
        UICapturingSlider.value = count;
    }
}
