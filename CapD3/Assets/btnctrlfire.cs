using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btnctrlfire : MonoBehaviour, IPointerDownHandler, IPointerUpHandler//, IPointerClickHandler
{
    public static float crntBtn = 0;
    public static float firebtn = 0;
    public static bool pressed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (crntBtn == 1)
        {
            firebtn = 1;
        }
        else if (crntBtn == 2)
        {
            firebtn = 2;
        }
        else if (crntBtn == 3)
        {
            firebtn = 3;
        }
        if (PauseButton.PauseBtn == true)
        {
            gameObject.SetActive(false);
        }
        if (PauseButton.PauseBtn == false)
        {
            gameObject.SetActive(true);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        crntBtn = 1;
        pressed = true;
        Debug.Log("발사포인트 다운");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        crntBtn = 2;
        pressed = false;
        Debug.Log("발사포인트 업");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        crntBtn = 3;
        pressed = true;
        Debug.Log("발사포인트 클릭");
    }
    public void resetbtn()
    {
        crntBtn = 0;
        firebtn = 0;
    }

}