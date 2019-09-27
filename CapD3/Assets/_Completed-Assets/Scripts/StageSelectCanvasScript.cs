using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectCanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject[] maps;
    [SerializeField] private GameObject[] canvas;
    [SerializeField] private GameObject[] tanks;
    [SerializeField] private GameObject[] turretsset;
    [SerializeField] private GameObject[] HPset;
    [SerializeField] private GameObject[] GCset;

    [SerializeField] private GameObject tankcontroller;
    [SerializeField] private GameObject cameracontroller;

    private Text[] texts;

    public static int stage = 0;
    public void Stage1BtnPressed()
    {
        stage = 1;
        Canvasturnon();
        //maps[0].SetActive(true);
        GameObject thismap = Instantiate(maps[0]);
        thismap.SetActive(true);
        //tanks[0].SetActive(true);
        GameObject thistank = Instantiate(tanks[0], Vector3.zero, Quaternion.Euler(new Vector3(0, 90, 0)));
        thistank.SetActive(true);
        TryController thiscontroller = tankcontroller.gameObject.GetComponent<TryController>();
        thiscontroller.go_Player = thistank;
        Complete.CameraControl thiscameracontroller = cameracontroller.gameObject.GetComponent<Complete.CameraControl>();
        thiscameracontroller.oldtank = thistank;
        GameObject thisHPset = Instantiate(HPset[0]);
        thisHPset.SetActive(true);
        //turretsset[0].SetActive(true);
        GameObject thisTurretset = Instantiate(turretsset[0]);
        thisTurretset.SetActive(true);
        GameObject thisGCset = Instantiate(GCset[0]);
        thisGCset.SetActive(true);
        GameCore songamecore = thisGCset.GetComponentInChildren<GameCore>();
        songamecore.settingcanvas(canvas[3]);
        texts = canvas[3].GetComponentsInChildren<Text>();
        Debug.Log(texts[0]);
        Debug.Log(texts[1]);

        StageSelectCanvasDisappearing();
    }

    public void Canvasturnon()
    {
        canvas[1].SetActive(true);
        //canvas[2].SetActive(true);
        canvas[3].SetActive(true);
    }
    public void BackToMainBtnPressed()
    {
        canvas[0].SetActive(true);

        StageSelectCanvasDisappearing();
    }
    
    public void StageSelectCanvasDisappearing()
    {
        this.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
