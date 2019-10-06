using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSetting : MonoBehaviour
{
    public static int timeset;
    // Start is called before the first frame update
    void Start()
    {
        TimeSet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TimeSet()
    {
        if (timeset <= 10)
        {
            timeset++;
        }
        InvokeRepeating("TimeSet", 4f, 0f);
    }
}
