using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBtnScript : MonoBehaviour
{
    [SerializeField] private GameObject newtestmap;
    [SerializeField] private GameObject newtesttank;
    [SerializeField] private GameObject newHP;


    [SerializeField] private GameObject oldCP;
    [SerializeField] private GameObject oldGC;
    [SerializeField] private GameObject oldtank;
    //[SerializeField] private GameObject completedtuesdaymap;
    // Start is called before the first frame update

    public void whenresetbtnpressed()
    {
        Debug.Log("reset버튼이 눌림");
        tryreset();
    }

    void tryreset()
    {
        oldtank.transform.position = new Vector3(0, 0, 0);
        oldtank.transform.rotation = Quaternion.Euler(0, 90, 0);
        oldGC.SetActive(true);
        CapturePoint tempCP = oldCP.GetComponent<CapturePoint>();
        tempCP.CPreset();
        this.gameObject.SetActive(false);
        /*
        destorypart();
        instantiatepart();
        movingpart();
        */
    }
    void destorypart()
    {

    }
    void instantiatepart()
    {

    }
    void movingpart()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
