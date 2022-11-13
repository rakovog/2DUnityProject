using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_2_2 : MonoBehaviour
{
    public Vector3 Axis;


    void Start()
    {   
        transform.position = Axis;
    }

    void Update()
    {

        if(transform.position.z < 5);
        {
            transform.position = new Vector3(10,0,0);
        }
    }
}
                