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
    // Start is called before the first frame update
    void Start()
    {
        timertext.text = "Time : START";
    }

    // Update is called once per frame
    void Update()
    {
        timeclock1 += Time.deltaTime;
        timeclock2 = Mathf.Round(timeclock1*10)*0.1f;
        
        timertext.text = "Time : " + timeclock2;

        //timeclock = Time.deltaTime;
        //timertext.text = "Time : " + ;
    }

}
