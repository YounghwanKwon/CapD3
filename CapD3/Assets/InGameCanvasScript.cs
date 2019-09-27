using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject text2;
    // Start is called before the first frame update
    [SerializeField] private GameObject resetbtn;
    [SerializeField] private GameObject timer;
    // Start is called before the first frame update

    public void text1on()
    {
        text1.SetActive(true);
    }
    public void text1off()
    {
        text1.SetActive(false);
    }
    public void text2on()
    {
        text2.SetActive(true);
    }
    public void text2off()
    {
        text2.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
