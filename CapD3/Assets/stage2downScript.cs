using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2downScript : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void OnTriggerStay(Collider other)
    {
        action1();
    }
    public void condition1()
    {
        action1();
    }
    public void action1()
    {
        Complete.TankHealth THscript = player.GetComponent<Complete.TankHealth>();
        THscript.TakeDamage(1.1f);
        THscript.GetHealing(1.05f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
