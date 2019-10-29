using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class btnchk : MonoBehaviour
{
    private bool btnchkF = false;
    public static float moveFval = 0;
    
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
