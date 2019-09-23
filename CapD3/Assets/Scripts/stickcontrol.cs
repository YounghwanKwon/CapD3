using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class stickcontrol : MonoBehaviour
{
    public Transform Stick1;

    private Vector3 StickSPos;  
    private Vector3 StickVec;         
    private float Rad;           

    // Start is called before the first frame update
    void Start()
    {
        Rad = GetComponent<RectTransform>().sizeDelta.y * 0.5f;
        StickSPos = Stick1.transform.position;

        // 반지름 조절.
        float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
        Rad *= Can;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Drag(BaseEventData _Data)
    {
        PointerEventData Data = _Data as PointerEventData;
        Vector3 Pos = Data.position;

        // 조이스틱을 이동시킬 방향을 구함.(오른쪽,왼쪽,위,아래)
        StickVec = (Pos - StickSPos).normalized;

        // 조이스틱의 처음 위치와 현재 내가 터치하고있는 위치의 거리를 구한다.
        float Dis = Vector3.Distance(Pos, StickSPos);

        // 거리가 반지름보다 작으면 조이스틱을 현재 터치하고 있는곳으로 이동. 
        if (Dis < Rad)
            Stick1.position = StickSPos + StickVec * Dis;
        // 거리가 반지름보다 커지면 조이스틱을 반지름의 크기만큼만 이동.
        else
            Stick1.position = StickSPos + StickVec * Rad;
    }
    public void DragEnd()
    {
        Stick1.position = StickSPos; // 스틱을 원래의 위치로.
        StickVec = Vector3.zero;          // 방향을 0으로.
    }
}
