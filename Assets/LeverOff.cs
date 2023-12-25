using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverOff : MonoBehaviour
{
    public GameObject Transmitter;

    private void OnTriggerEnter(Collider other)
    {
        Transmitter.GetComponent<AudioSource>().loop = false;
        Transmitter.GetComponent<AudioSource>().Stop();
    }
}
