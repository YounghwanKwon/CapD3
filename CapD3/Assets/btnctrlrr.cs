using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btnctrlrr : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isBtnDown = false;
    public static float moveforr = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isBtnDown)
        {
            moveforr = 1;
        }
        else
        {
            moveforr = 0;
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