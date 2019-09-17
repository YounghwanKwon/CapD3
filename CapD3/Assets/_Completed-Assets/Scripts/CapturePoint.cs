using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePoint : MonoBehaviour
{
    [SerializeField] private float count=0f;
    [SerializeField] public int tencheck = 0;
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform CapturePointPos;
    [SerializeField] private Vector3 howfarvec;
    [SerializeField] private float howfar;
    [SerializeField] private bool capturing = false;
    // Start is called before the first frame update

    void tryCapturing()
    {
        while (count < 900.0f && capturing == true)
        {
            howfarvec = new Vector3(Mathf.Abs(tank.transform.position.x - CapturePointPos.transform.position.x), 0, Mathf.Abs(tank.transform.position.z - CapturePointPos.transform.position.z));
            count += Time.deltaTime;
            
            if(count >= tencheck)
            {
                Debug.Log("count: " + count + " tencheck: " + tencheck+" howfarvec: " +howfarvec);
                tencheck += 100;
            }
            distancecheck();
        }
        if (count >= 900.0f)
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (capturing == false)
            distancecheck();
    }

    void distancecheck()
    {
        if (Vector3.Distance(CapturePointPos.transform.position, tank.transform.position) <= 5.0f)
        {
            if (capturing == false)
            {
                capturing = true;
                tryCapturing();
            }
        }
        else
            capturing = false;
    }
}
