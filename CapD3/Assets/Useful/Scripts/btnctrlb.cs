using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btnctrlb : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isBtnDown = false;
    public static float moveforb = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isBtnDown)
        {
            moveforb = -1;
        }
        else
        {
            moveforb = 0;
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