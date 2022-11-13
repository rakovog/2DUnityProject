using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScripts_2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}