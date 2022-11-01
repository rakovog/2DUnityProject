using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW_2 : MonoBehaviour
{
    public int N=0;
    public int M=0;
    // Start is called before the first frame update
    void Start()
    {
        if (N >= M)
        {
            Debug.Log("YES");
        }
        else if (N<M)
        {
            Debug.Log("NO");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

