using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_3_1 : MonoBehaviour
    {
        public int N;
        public int Z;
        int S;
        void Start()
        {   S=Z;
                for (int C = 1; C <= N; C += 1)
            {   
                Z *= S;
                Debug.Log(Z);
            }
        }

        void Update()
        {

        }
    }