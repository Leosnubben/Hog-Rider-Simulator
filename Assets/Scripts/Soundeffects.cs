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
    AudioClip ScreamThree;   //S� man kan v�lja vad f�r ljud som ska spelas - Leo
    private void Start()
    {
        source = GetComponent<AudioSource>();  //G�r s� man spelar ljudet ur en audio source - Leo
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
    }   //Man v�ljer vad f�r ljud och s� spelar den ljudet n�r man trycker p� respektive knapp - Leo
}
