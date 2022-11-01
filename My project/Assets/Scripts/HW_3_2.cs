using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_3_2 : MonoBehaviour
    {
        public float Sum;
        float Sum1;
        float Sum2;
        public int Num;
        public int Proc;
        void Start()
        {
            Sum1=Sum;
            Sum2=Sum;
                for (int C = 1; C <= Num; C += 1)
            {   
                Sum1 += Sum1 / 100 * Proc;
                Sum2 += Sum / 100 * Proc;
            }
            //Сложный процент
            Debug.Log(Sum1);
            //Простой процент
            Debug.Log(Sum2);
            //Разница
            Debug.Log(Sum1-Sum2);

        }

        void Update()
        {

        }
    }