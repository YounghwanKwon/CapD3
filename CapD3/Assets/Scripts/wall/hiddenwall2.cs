using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenwall2 : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private Transform spwanpoint;
    [SerializeField] private GameObject HC;
    [SerializeField] private GameObject originwall;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        hiddenwall hiddenwallorigin = originwall.GetComponent<hiddenwall>();
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("플레이어가 벽에 도달하였습니다");
            Debug.Log("탱크넷소환을 시도합니다");
            hiddenwallorigin.spwanonetank();
            hiddenwallorigin.spwanonetank();
            hiddenwallorigin.spwanonetank();
            hiddenwallorigin.spwanonetank();
            //Instantiate(tank, spwanpoint.position, spwanpoint.rotation);


            this.gameObject.SetActive(false);
            //tank.Setup();
            //HC = Instantiate(HC, spwanpoint, spwanpoint.rotation);
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
