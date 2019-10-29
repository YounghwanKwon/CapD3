using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControl : MonoBehaviour
{
    public GameObject Raybody;
    public GameObject ScaleDistance;
    public GameObject RayResult;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Physics.Raycast(transform.position, transform.forward, out hit, 200);

        ScaleDistance.transform.localScale = new Vector3(1, hit.distance, 1);

        RayResult.transform.position = hit.point;

        RayResult.transform.rotation = Quaternion.LookRotation(hit.normal);
    }
}
