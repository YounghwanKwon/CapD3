using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBtnScript : MonoBehaviour
{
    [SerializeField] private GameObject testmap1;
    [SerializeField] private GameObject testtank1;
    [SerializeField] private GameObject testIngamecanvas;
    [SerializeField] private GameObject buttoncanvas;
    // Start is called before the first frame update

    public void whenbuttonpressed()
    {
        testmap1.gameObject.SetActive(true);
        testtank1.gameObject.SetActive(true);
        gameObject.SetActive(false);
        testIngamecanvas.gameObject.SetActive(true);
        buttoncanvas.SetActive(true);

        /*
        Slider UIhealthslider = testIngamecanvas.GetComponentInChildren<Slider>();
        UIhealthslider.gameObject.SetActive(false);
        */

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
