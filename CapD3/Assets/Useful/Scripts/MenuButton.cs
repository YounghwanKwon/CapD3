using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerClickHandler
{
    public static bool PauseBtn = false;
    public GameObject MoveImage;
    public GameObject FireButton;
    public GameObject ResumeButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseBtn)
        {
            MoveImage.SetActive(false);
            FireButton.SetActive(false);
            ResumeButton.SetActive(true);
            Time.timeScale = 0;
            return;
        }
        if(!PauseBtn)
        {
            MoveImage.SetActive(true);
            FireButton.SetActive(true);
            ResumeButton.SetActive(false);
            Time.timeScale = 1;
            return;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        PauseBtn = true;
    }

}
