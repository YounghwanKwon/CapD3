using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneunmovefy : MonoBehaviour
{
    [SerializeField] private GameObject drone;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            droneunmove();
        }
    }

    public void droneunmove()
    {
        MovementE moveE = drone.GetComponent<MovementE>();
        moveE.powerofffunc();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
