using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBtnScript : MonoBehaviour
{
    [SerializeField] private GameObject newtestmap;
    [SerializeField] private GameObject newtesttank;
    [SerializeField] private GameObject newHP;
    [SerializeField] private GameObject newGC;
    [SerializeField] private GameObject newCP;
    //[SerializeField] private GameObject completedtuesdaymap;
    // Start is called before the first frame update

    public void whenresetbtnpressed()
    {
        Debug.Log("reset버튼이 눌림");
        tryreset();
    }

    void tryreset()
    {
        destorypart();
        instantiatepart();
        movingpart();
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
