using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisions2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
//        Destroy(collision.gameObject);
        collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 10, 0);
        Debug.Log(collision.gameObject.name);
    }
}

