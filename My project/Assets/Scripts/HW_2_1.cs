using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_2_1 : MonoBehaviour
{
    public float t=0;
    public float s=0;
    public float dist=0;
    float total = 0;
    // Start is called before the first frame update
    void Start()
    {   
        total = t * s;
        if (total == dist)
        {
            Debug.Log("Доехал");
        }
        else if (total > dist)
        {
            Debug.Log("Переехал");
        }
        else if (total < dist)
        {
            Debug.Log("Не доехал");
        }
    }
    void Update()
    {
        
    }
}

