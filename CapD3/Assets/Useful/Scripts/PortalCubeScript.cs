using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCubeScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform Destination;
    [SerializeField] private Transform Destination2;
    [SerializeField] private GameObject s2m;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("from portal script SubCorecount : "+GameSubCoreScript.SubCorecount);
            if (StageSaveScript.StageNum == 2 && GameSubCoreScript.SubCorecount == 3)
            {
                Transform playerTF = other.GetComponent<Transform>();
                playerTF.transform.position = Destination2.position;
            }
            else
            {
                Transform playerTF = other.GetComponent<Transform>();
                playerTF.transform.position = Destination.position;
                Complete.TankHealth th = player.GetComponent<Complete.TankHealth>();
                th.GetHealing(60.0f);
            }
            
        }
    }
}
