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
    [SerializeField] private float timeamount;
    private float distanceamount;

    private float realtimer = 0.0f;
    private bool onlyone = false;
    private bool Istotallycaptured = false;
    private DateTime OneSecLater;
    private TimeSpan span;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject Tmanager;
    private TutorialManagerScript Tmanagerscript;

    void tryCapturing()
    {
        if (count < timeamount && capturing == true)
        {
            tryaddcount();
            
            if(count - 1.0f >= tencheck)
            {
                Debug.Log("count: " + count + " tencheck: " + tencheck);
                tencheck += 1;
            }
            distancecheck();
        }
        if (Tmanager)
        {
            int i = Tmanagerscript.gettercontine();
            if(count !=0f && i == 9)
            {
                Tmanagerscript.addcontinue();
            }
        }
        if (count >= 15.0f)
        {
            Istotallycaptured = true;
            if (onlyone == false)
            {
                if (Tmanager)
                {
                    int i = Tmanagerscript.gettercontine();
                    if(i == 10)
                        Tmanagerscript.addcontinue();
                }
                else
                {
                    test1.SetActive(true);

                    TimerScript temptimer = timer.GetComponent<TimerScript>();
                    temptimer.timepassoff();
                    PauseCanvasScript canvasscript = canvas.GetComponent<PauseCanvasScript>();
                    canvasscript.whenuserdead();

                    Invoke("deactive", 2);
                    onlyone = true;
                }
            }
        }
        
    }
    void deactive()
    {
        test1.SetActive(false);
        resetbtn.SetActive(true);
    }
    public void CPreset()
    {
        count = 0;
        SetUICapturingSlider();
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
        count += Time.deltaTime;
        SetUICapturingSlider();
    }
    void OneSeclaterfunc()
    {
        
        OneSecLater = DateTime.Now;
        span = OneSecLater - now;
        span = TimeSpan.Zero;
        now = DateTime.Now;
    }
    void Start()
    {
        distanceamount = 24.0f;
        if (timeamount == 0)
            timeamount = 30.0f;
        SetUICapturingSlider();
        if (Tmanager)
        {
            distanceamount = 5.0f;
            Tmanagerscript = Tmanager.GetComponent<TutorialManagerScript>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (count > 0f && count <= 15.0f)
        {
            UICapturingSlider.gameObject.SetActive(true);
        }
        else
            UICapturingSlider.gameObject.SetActive(false);

        if (capturing == false && Istotallycaptured == false)
            distancecheck();
        else
            tryCapturing();
    }

    void distancecheck()
    {
        if (Vector3.Distance(CapturePointPos.transform.position, tank.transform.position) <= distanceamount)
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
