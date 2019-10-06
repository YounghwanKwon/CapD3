using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2DodgeFieldScript : MonoBehaviour
{
    private float xvalue1 = 0f;
    private float xvalue2 = 0f;
    private float xvalue3 = 0f;
    private float zvalue1 = 0f;
    private float zvalue2 = 0f;
    [SerializeField] private Transform BombPlacingPoint1;
    [SerializeField] private Transform BombPlacingPoint2;
    [SerializeField] private Transform BombPlacingPoint3;
    [SerializeField] private Transform BombPlacingPoint4;
    [SerializeField] private Transform BombPlacingPoint5;
    private bool needboom1 = true;
    private Transform transs1;
    private Transform transs2;
    private Transform transs3;
    private Transform transs4;
    private Transform transs5;
    [SerializeField] private GameObject shell1;
    // Start is called before the first frame update
    void Start()
    {
        setandbombatFirst();
        setandbombatSecond();
        setandbombatThird();
        setandbombatFourth();
        setandbombatFifth();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setandbombatFirst()
    {
        if (needboom1 == true)
        {
            transs1 = transform;
            //Debug.Log(BombPlacingPoint1.transform+"3");
            for (float i = 0f; i < 2; i++)
            {
                transs1.transform.position = new Vector3(5.0f * xvalue1 + BombPlacingPoint1.transform.position.x, BombPlacingPoint1.transform.position.y, 2.5f);
                Drophere(transs1);
                transs1.transform.position = new Vector3(5.0f * xvalue1 + BombPlacingPoint1.transform.position.x, BombPlacingPoint1.transform.position.y, -2.5f);
                Drophere(transs1);
                //Debug.Log(i);
                setxpos1(transs1);                
            }
            Invoke("setandbombatFirst", 0.4f);
        }
        
    }
    void setandbombatSecond()
    {
        if (needboom1 == true)
        {
            transs2 = transform;
            //Debug.Log(BombPlacingPoint1.transform+"3");
            for (float i = 0f; i < 2; i++)
            {
                transs2.transform.position = new Vector3(BombPlacingPoint2.transform.position.x + 2.5f, BombPlacingPoint1.transform.position.y, 5.0f * zvalue1 + BombPlacingPoint2.transform.position.z);
                Drophere(transs2);
                transs2.transform.position = new Vector3(BombPlacingPoint2.transform.position.x - 2.5f, BombPlacingPoint1.transform.position.y, 5.0f * zvalue1 + BombPlacingPoint2.transform.position.z);
                Drophere(transs2);
                //Debug.Log(i);
                setzpos1(transs2);
            }
            Invoke("setandbombatSecond", 0.4f);
        }

    }
    void setandbombatThird()
    {
        if (needboom1 == true)
        {
            transs3 = transform;
            //Debug.Log(BombPlacingPoint1.transform+"3");
            for (float i = 0f; i < 2; i++)
            {
                transs3.transform.position = new Vector3(5.0f * xvalue2 + BombPlacingPoint3.transform.position.x, BombPlacingPoint3.transform.position.y, BombPlacingPoint3.transform.position.z - 2.5f);
                Drophere(transs3);
                transs3.transform.position = new Vector3(5.0f * xvalue2 + BombPlacingPoint3.transform.position.x, BombPlacingPoint3.transform.position.y, BombPlacingPoint3.transform.position.z + 2.5f);
                Drophere(transs3);
                //Debug.Log(i);
                setxpos2(transs3);
            }
            Invoke("setandbombatThird", 0.4f);
        }

    }
    void setandbombatFourth()
    {
        if (needboom1 == true)
        {
            transs4 = transform;
            //Debug.Log(BombPlacingPoint1.transform+"3");
            for (float i = 0f; i < 2; i++)
            {
                transs4.transform.position = new Vector3(BombPlacingPoint4.transform.position.x + 2.5f, BombPlacingPoint4.transform.position.y, -5.0f * zvalue2 + BombPlacingPoint4.transform.position.z);
                Drophere(transs4);
                transs4.transform.position = new Vector3(BombPlacingPoint4.transform.position.x - 2.5f, BombPlacingPoint4.transform.position.y, -5.0f * zvalue2 + BombPlacingPoint4.transform.position.z);
                Drophere2(transs4);
                //Debug.Log(i);
                setzpos2(transs4);
            }
            Invoke("setandbombatFourth", 0.4f);
        }

    }
    void setandbombatFifth()
    {
        if (needboom1 == true)
        {
            transs5 = transform;
            //Debug.Log(BombPlacingPoint1.transform+"3");
            for (float i = 0f; i < 2; i++)
            {                
                transs5.transform.position = new Vector3(5.0f * xvalue3 + BombPlacingPoint5.transform.position.x, BombPlacingPoint5.transform.position.y, BombPlacingPoint5.transform.position.z - 2.5f);
                Drophere(transs5);
                transs5.transform.position = new Vector3(5.0f * xvalue3 + BombPlacingPoint5.transform.position.x, BombPlacingPoint5.transform.position.y, BombPlacingPoint5.transform.position.z + 2.5f);
                Drophere(transs5);
                //Debug.Log(i);
                setxpos3(transs5);
            }
            Invoke("setandbombatFifth", 0.4f);
        }

    }


    void setxpos1(Transform Atransform)
    {
        //Debug.Log("called setxpos169");
        if (xvalue1 < 17)
        {
            xvalue1++;
        }
        else if (xvalue1 >= 17)
        {
            xvalue1 = 0;
        }
        else
        {
            Debug.Log("오류");
        }
    }
    void setxpos2(Transform Atransform)
    {
        //Debug.Log("called setxpos169");
        if (xvalue2 < 17)
        {
            xvalue2++;
        }
        else if (xvalue2 >= 17)
        {
            xvalue2 = 0;
        }
        else
        {
            Debug.Log("오류");
        }
    }
    void setxpos3(Transform Atransform)
    {
        //Debug.Log("called setxpos169");
        if (xvalue3 < 17)
        {
            xvalue3++;
        }
        else if (xvalue3 >= 17)
        {
            xvalue3 = 0;
        }
        else
        {
            Debug.Log("오류");
        }
    }
    void setzpos1(Transform Atransform)
    {
        //Debug.Log("called setxpos169");
        if (zvalue1 < 17)
        {
            zvalue1++;
        }
        else if (zvalue1 >= 17)
        {
            zvalue1 = 0;
        }
        else
        {
            Debug.Log("오류");
        }
    }
    void setzpos2(Transform Atransform)
    {
        //Debug.Log("called setxpos169");
        if (zvalue2 < 17)
        {
            zvalue2++;
        }
        else if (zvalue2 >= 17)
        {
            zvalue2 = 0;
        }
        else
        {
            Debug.Log("오류");
        }
    }
    void Drophere(Transform Atransform)
    {

        //Debug.Log("called Drop258");
        //setxpos(Atransform);
        GameObject thisshell = Instantiate(shell1, Atransform);
        thisshell.transform.parent = null;
        //Instantiate(shell1,new Vector3(0,0.1f,0),Quaternion.Euler(Vector3.zero));
        //Invoke("DropA", 2);
    }
    void Drophere2(Transform Atransform)
    {

        //Debug.Log("called Drop258");
        //setxpos(Atransform);
        GameObject thisshell2 = Instantiate(shell1, Atransform);
        thisshell2.transform.parent = null;
        //Instantiate(shell1,new Vector3(0,0.1f,0),Quaternion.Euler(Vector3.zero));
        //Invoke("DropA", 2);
    }
}
