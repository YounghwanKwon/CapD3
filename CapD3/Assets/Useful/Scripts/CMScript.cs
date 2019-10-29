using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMScript : MonoBehaviour
{
    [SerializeField] private GameObject[] childrens;
    [SerializeField] private GameObject centerbombpos;
    [SerializeField] private GameObject shell1;
    [SerializeField] private GameObject shell2;
    private bool needboom = true;
    private int i;
    private int j=0;
    // Start is called before the first frame update
    void Start()
    {
        i = (int)Random.Range(0f, 7f);
        Invoke("randombomb", 0.5f);
        Invoke("centerbomb", 2.5f);
    }
    public void randombomb()
    {
        if(needboom == true)
        {
            i = (int)(Random.value * 100);
            j++;
            i %= 8;
            j %= 8;
            drophere(childrens[i].transform);
            drophere(childrens[j].transform);
            Invoke("randombomb", 1.5f);
        }
    }
    public void centerbomb()
    {
        if (needboom == true)
        {
            GameObject shell12 = Instantiate(shell2, centerbombpos.transform);
            shell12.SetActive(true);
            shell12.transform.parent = null;
            Invoke("centerbomb", 5f);
        }
    }
    public void drophere(Transform A)
    {
        GameObject shell11 =  Instantiate(shell1, A);
        shell11.SetActive(true);
        shell11.transform.parent = null;
    }
    public void needboomfalsefy()
    {
        needboom = false;
    }
}
