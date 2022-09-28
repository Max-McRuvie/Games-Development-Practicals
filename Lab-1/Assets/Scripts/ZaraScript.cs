using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ZaraScript : MonoBehaviour
{
    // Use this for initialization
    void OnTriggerEnter(Collider ent)
    {
        this.GetComponent<AudioSource>().Play();
    }
    void OnTriggerExit(Collider ext)
    {
        this.GetComponent<AudioSource>().Stop();
    }
}
