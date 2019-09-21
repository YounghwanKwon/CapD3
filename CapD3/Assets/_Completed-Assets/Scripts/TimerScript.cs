using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Text timertext;

    private float timeclock1= 0.0f;
    private float timeclock2 = 0.0f;
    private Time timeclock;

    private bool timepassing = false;
    // Start is called before the first frame update
    void Start()
    {
        timertext.text = "Time : START";
        timepasson();
    }

    // Update is called once per frame
    void Update()
    {
        if (timepassing == true)
        {
            timeclock1 += Time.deltaTime;
            timeclock2 = Mathf.Round(timeclock1 * 10) * 0.1f;

            timertext.text = "Time : " + timeclock2;

            //timeclock = Time.deltaTime;
            //timertext.text = "Time : " + ;
        }

    }

    public void timepassoff()
    {
        timepassing = false;
    }

    public void timepasson()
    {
        timepassing = true;
    }
    public void timezerofy()
    {
        timeclock1 = 0f;
    }

}
