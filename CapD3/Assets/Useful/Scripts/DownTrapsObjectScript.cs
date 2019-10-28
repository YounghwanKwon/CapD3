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
        //Time.timeScale = 0.1f;
        Debug.Log("스폰 밤");
        setspwanlocation();
        GameObject Bomb = Instantiate(bombs, spwanlocation.transform);
        Bomb.transform.position = new Vector3(Bomb.transform.position.x+3.0f, Bomb.transform.position.y + 1000.0f, Bomb.transform.position.z + 3.0f);
        Bomb.transform.parent = null;
        //Bomb.SetActive(true);
        Invoke("spwanbombair", 1);

    }

    public void setspwanlocation()
    {
        spwanlocation.transform.position = objplayer.transform.position;
    }
    public void condition1()
    {
        //플레이어가 미로안에 있을때

    }

    // Start is called before the first frame update
    void Start()
    {
        objplayer = GameObject.FindGameObjectWithTag("Player");
        setspwanlocation();
        //spwanbombair();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
