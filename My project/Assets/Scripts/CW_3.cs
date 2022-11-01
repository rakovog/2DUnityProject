using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW_4 : MonoBehaviour
{
    public int n;
    // Start is called before the first frame update
    void Start()
    {
            for (int oleg = 0; oleg <= n; oleg ++)
        {       if (oleg % 2 == 0)
                {
                    Debug.Log(oleg);
                }
        }
    }   

    // Update is called once per frame
    void Update()
    {

    }
}