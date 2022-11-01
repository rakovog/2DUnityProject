using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_4_2 : MonoBehaviour
{
    int Num=0;
    int[] a={6, 1, -2, -9, 1, -3, -13};

    void Start()
    {
            for (int oleg = 0; oleg < 6; oleg ++)
        {
                for (int oleg1 = 0; oleg1 < 6; oleg1 ++)
                {
                       if (a[oleg] < a[oleg1])
                        {   
                           Num=a[oleg];
                        }   
                }
        }   
        Debug.Log(Num);
    }   

    void Update()
    {

    }
}