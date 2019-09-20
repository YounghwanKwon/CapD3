using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingTest : MonoBehaviour
{
    [SerializeField] public GameObject Target;
    [SerializeField] private float speed=0.05f;
    private Vector3 difValue;
     

    // Start is called before the first frame update
    void Start()
    {
        difValue = transform.position - Target.transform.position;
        difValue = new Vector3(Mathf.Abs(difValue.x), Mathf.Abs(difValue.y), Mathf.Abs(difValue.z));
        difValue = new Vector3(0, 30, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Target.transform.position+difValue, speed);
    }
}
