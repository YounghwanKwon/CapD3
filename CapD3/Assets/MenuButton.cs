using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool PauseBtn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseBtn)
        {
            Time.timeScale = 0;
            return;
        }
        if(!PauseBtn)
        {
            Time.timeScale = 1;
            return;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        PauseBtn = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PauseBtn = false;
    }
}
