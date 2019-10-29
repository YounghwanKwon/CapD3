using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRottoPlayer : MonoBehaviour
{
    public GameObject Player;
    public Vector3 SetVec;
    public float xpos;
    public float zpos;
    [SerializeField] private GameObject Golem;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("SetRot", 0f, 0.01f);
    }
    void SetRot()
    {
        if (Golem.gameObject.activeSelf == true)
        {
            SetVec = this.transform.position - Player.transform.position;
            xpos = SetVec.x;
            zpos = SetVec.z;
            this.transform.rotation = Quaternion.Euler(0, Mathf.Atan2(xpos, zpos) * Mathf.Rad2Deg + 180, 0);
        }
    }
}
