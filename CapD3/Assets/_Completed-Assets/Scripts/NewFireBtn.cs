using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewFireBtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject oldtank;
    [SerializeField] private bool button;


    // Start is called before the first frame update
    void Start()
    {
        Complete.TankShooting tankShooting = oldtank.GetComponent<Complete.TankShooting>();
        button = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (button == true)
        {
            Input.GetButton("Fire1");
        }
        else
            Input.GetButtonUp("Fire1");
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        button = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        button = false;
    }
}
