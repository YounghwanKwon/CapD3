using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPosition1 : MonoBehaviour
{
    public static bool posstatus1;
    // Start is called before the first frame update
    void Start()
    {
        posstatus1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        Debug.Log("postion1 test");
        posstatus1 = true;
        BotPosition2.posstatus2 = false;
    }
}
