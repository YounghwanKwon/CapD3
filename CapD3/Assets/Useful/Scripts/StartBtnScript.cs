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
    [SerializeField] private GameObject turrets;
    public void whenbuttonpressed()
    {
        testmap1.gameObject.SetActive(true);
        testtank1.gameObject.SetActive(true);
        turrets.gameObject.SetActive(true);
        gameObject.SetActive(false);
        testIngamecanvas.gameObject.SetActive(true);
        buttoncanvas.SetActive(true);
    }
}
