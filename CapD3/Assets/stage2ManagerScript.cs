using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2ManagerScript : MonoBehaviour
{
    public static int stagenumber;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject resetbtn;
    // Start is called before the first frame update
    void Start()
    {
        stagenumber = 2;
        IngameCanvasScript canvasscript = canvas.GetComponent<IngameCanvasScript>();
        canvasscript.setstagenumber(stagenumber);
        ResetBtnScript canvasscript2 = resetbtn.GetComponent<ResetBtnScript>();
        canvasscript2.setstage(stagenumber);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
