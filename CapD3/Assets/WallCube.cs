using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallCube : MonoBehaviour
{
    [SerializeField] private GameObject s1manager;
    private stage1ManagerScript s1mscript;
    [SerializeField] private Slider UICaptureslider;
    [SerializeField] private GameObject lazerturret;

    public GameObject BallBomb0;
    public GameObject BallBomb1;
    public GameObject BallBomb2;
    public GameObject BallBomb3;
    public GameObject BallBomb4;
    public GameObject BallBomb5;
    public GameObject BallBomb6;
    public GameObject BallBomb7;
    public GameObject BallBomb8;
    public GameObject BallBomb9;
    public GameObject FrontWall;
    public GameObject BackWall;
    public GameObject exitarrow;
    public float time = 0;
    public float SettingTime = 0;
    public bool TrapStart = false;
    // Start is called before the first frame update
    void Start()
    {
        if (s1manager)
            s1mscript = s1manager.GetComponent<stage1ManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.CompareTag("Player"))
        {
            this.transform.position = new Vector3(0f, 0f, -1f);
            BallBomb0.SetActive(true);
            lazerturret.SetActive(true);
            FrontWall.SetActive(true);
            BackWall.SetActive(true);
            StartCoroutine(Timer());
        }
        else
        {
            Debug.Log("버그");
        }

    }
    IEnumerator Timer()
    {
        while (true)
        {
            time++;
            setslider();
            SettingTime = Mathf.Round(time);
            if (SettingTime == 2)
            {
                BallBomb1.SetActive(true);
            }
            if (SettingTime == 4)
            {
                BallBomb2.SetActive(true);
            }
            if (SettingTime == 6)
            {
                BallBomb3.SetActive(true);
            }
            if (SettingTime == 8)
            {
                BallBomb4.SetActive(true);
            }
            if (SettingTime == 10)
            {
                BallBomb5.SetActive(true);
            }
            if (SettingTime == 12)
            {
                BallBomb6.SetActive(true);
            }
            if (SettingTime == 14)
            {
                BallBomb7.SetActive(true);
            }
            if (SettingTime == 16)
            {
                BallBomb8.SetActive(true);
            }
            if (SettingTime == 18)
            {
                BallBomb9.SetActive(true);
            }
            if (SettingTime == 30)
            {
                setslider();
                this.gameObject.SetActive(false);
                //FrontWall.SetActive(false);
                exitarrow.SetActive(true);
                BackWall.SetActive(false);
                s1mscript.order3gooutright();
            }
            yield return new WaitForSeconds(1);
        }
    }
    void setslider()
    {
        if (time > 0 && time < 30.0f)
        {
            UICaptureslider.gameObject.SetActive(true);
            UICaptureslider.value = time;
        }
        else
        {
            UICaptureslider.gameObject.SetActive(false);
            Debug.Log("i hoped this slider disable");
        }

    }

}


