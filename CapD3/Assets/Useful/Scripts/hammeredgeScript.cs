using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammeredgeScript : MonoBehaviour
{
    [SerializeField] private GameObject hammersshell;
    public void OnTriggerEnter(Collider other)
    {
       // Debug.Log("1hit something :"+other);
        if (other.CompareTag("Hammersetground"))
        {
            GameObject shell = Instantiate(hammersshell, this.transform);
            //shell.transform.parent = null;
            //Time.timeScale = 0;
        }
        else if(other.CompareTag("Player"))
        {
            Complete.TankHealth TH = other.GetComponent<Complete.TankHealth>();
            TH.TakeDamage(100.0f);
            //Time.timeScale = 0;
        }
        //else
           // Debug.Log("2hit something :" + other);
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hammer move");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
