using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_4_1 : MonoBehaviour
{
    int[] a={6, 1, -2, -9, 1, -3, -13};

    void Start()
    {
        int min= a[0];
            for (int oleg = 0; oleg < 6; oleg ++)
        { 
            if (min>a[oleg]);
            min = a[oleg];
        }
        Debug.Log(min);
    }   

    // Update is called once per frame
    void Update()
    {

    }
}