using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMScript : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    [SerializeField] private GameObject shell1;
    private int i;
    private int j=0;
    // Start is called before the first frame update
    void Start()
    {
        i = (int)Random.Range(0f, 7f);
        InvokeRepeating("randombomb", 2.5f, 4.5f);
    }
    public void randombomb()
    {
        i = (int)(Random.value*100);
        j++;
        i %= 8;
        j %= 8;
        drophere(childrens[i].transform);
        drophere(childrens[j].transform);
    }
    public void drophere(Transform A)
    {
        GameObject shell11 =  Instantiate(shell1, A);
        shell11.SetActive(true);
        shell11.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
