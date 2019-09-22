using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class btnchk : MonoBehaviour
{
    private bool btnchkF = false;
    public static float moveFval = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        btnchkF = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        btnchkF = false;
    }
    public float moveF()
    {
        if (btnchkF == true)
            return 1;
        
        else
            return 0;
        
    }

}
