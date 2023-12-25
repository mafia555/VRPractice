using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Transmitter;

    public static event Action LeverPull;

    private void OnTriggerEnter(Collider other)
    {
        Transmitter.GetComponent<AudioSource>().loop = true;
        Transmitter.GetComponent<AudioSource>().Play();
    }

}
