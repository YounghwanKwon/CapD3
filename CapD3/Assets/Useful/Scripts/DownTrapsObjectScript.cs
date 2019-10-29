using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTrapsObjectScript : MonoBehaviour
{
    [SerializeField] private GameObject bombs;
    [SerializeField] private GameObject spwanlocation;
    [SerializeField] private GameObject condition1detector;
    private GameObject objplayer;
    public void spwanbombair()
    {
        setspwanlocation();
        GameObject Bomb = Instantiate(bombs, spwanlocation.transform);
        Bomb.transform.position = new Vector3(Bomb.transform.position.x+3.0f, Bomb.transform.position.y + 1000.0f, Bomb.transform.position.z + 3.0f);
        Bomb.transform.parent = null;
        Invoke("spwanbombair", 1);

    }

    public void setspwanlocation()
    {
        spwanlocation.transform.position = objplayer.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        objplayer = GameObject.FindGameObjectWithTag("Player");
        setspwanlocation();
    }
}
