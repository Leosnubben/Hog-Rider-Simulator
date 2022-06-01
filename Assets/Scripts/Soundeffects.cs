using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffects : MonoBehaviour
{
    AudioSource source;

    [SerializeField]
    AudioClip ScreamOne;
    [SerializeField]
    AudioClip ScreamTwo;
    [SerializeField]
    AudioClip ScreamThree;   //Så man kan välja vad för ljud som ska spelas - Leo
    private void Start()
    {
        source = GetComponent<AudioSource>();  //Gör så man spelar ljudet ur en audio source - Leo
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            source.PlayOneShot(ScreamOne);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            source.PlayOneShot(ScreamTwo);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            source.PlayOneShot(ScreamThree);  
        }
    }   //Man väljer vad för ljud och så spelar den ljudet när man trycker på respektive knapp - Leo
}
