using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public static int resetcount = 0;
    // Start is called before the first frame update

    public void whenexitpressed()
    {
        Application.Quit();
    }

    public void countup()
    {
        resetcount++;
        Debug.Log(resetcount);
        if (resetcount >= 2)
        {
            this.gameObject.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
