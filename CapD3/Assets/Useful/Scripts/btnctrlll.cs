using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btnctrlll : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isBtnDown = false;
    public static float moveforl = 0;
    
    // Update is called once per frame
    void Update()
    {
        if (isBtnDown)
        {
            moveforl = -1;
        }
        else
        {
            moveforl = 0;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isBtnDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;
    }
}