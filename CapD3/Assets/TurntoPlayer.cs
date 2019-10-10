using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurntoPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject ObjtoTurn;
    public Vector3 SetVec;
    public float xpos;
    public float zpos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetRot();
    }
    void SetRot()
    {
        SetVec = this.transform.position - Player.transform.position;
        xpos = SetVec.x;
        zpos = SetVec.z;
        Debug.Log(Mathf.Atan2(xpos, zpos) * Mathf.Rad2Deg);
        if (ObjtoTurn.transform.eulerAngles.y != Mathf.Atan2(xpos, zpos) * Mathf.Rad2Deg + 180)
        {
            ObjtoTurn.transform.eulerAngles = new Vector3(0, (Mathf.Atan2(xpos, zpos) * Mathf.Rad2Deg + 180) * Time.deltaTime, 0);
        }
    }
}