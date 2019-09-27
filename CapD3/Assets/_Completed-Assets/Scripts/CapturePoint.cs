using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CapturePoint : MonoBehaviour
{
    private float count=0.0f;
    private int tencheck = 0;
    [HideInInspector] private GameObject tank;
    private Transform CapturePointPos;
    private bool capturing = false;
    
    private DateTime now;
    [HideInInspector] private GameObject Ingamecanvas1;
    [HideInInspector] private InGameCanvasScript thatingamescript;
    [HideInInspector] private Text text2;
    //[SerializeField] private GameObject resetbtn;
    //[SerializeField] private GameObject timer;
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
                thatingamescript.text2on();

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
        Ingamecanvas1.SetActive(false);
        //resetbtn.SetActive(true);
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
        count += Time.deltaTime;
        SetUICapturingSlider();
        Debug.Log("count: " + count);
    }

    void OneSeclaterfunc()
    {
        OneSecLater = DateTime.Now;
        span = OneSecLater - now;
        Debug.Log("span.totalSeconds: " + span.TotalSeconds);
        Debug.Log("span.TotalMilliseconds: " + span.TotalMilliseconds);
        
        Debug.Log("count: " + count);
        span = TimeSpan.Zero;
        now = DateTime.Now;
    }

    public void settingtank(GameObject tankfromout) {
        tank = tankfromout;
        Debug.Log(tank + "from CP.cs");
    }

    public void settingUIslider(Slider Sliderfromout)
    {
        UICapturingSlider = Sliderfromout;
    }
    void Start()
    {
        CapturePointPos = this.transform;
        settingScript();
        SetUICapturingSlider();
    }

    // Update is called once per frame
    void Update()
    {
        SetUICapturingSlider();
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

    public void settingScript()
    {
        thatingamescript = Ingamecanvas1.GetComponent<InGameCanvasScript>();
    }
    public void settingCanvas(GameObject canvasfromout)
    {
        Ingamecanvas1 = canvasfromout;
    }
}
