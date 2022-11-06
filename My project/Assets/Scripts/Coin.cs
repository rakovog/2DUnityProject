using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Vector3 Axis;
    void Start()
    {
        transform.position = Axis;
        transform.position = new Vector3(10,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
