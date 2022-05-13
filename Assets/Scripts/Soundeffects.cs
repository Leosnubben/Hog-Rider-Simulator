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
    AudioClip ScreamThree;
    private void Start()
    {
        source = GetComponent<AudioSource>();
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
    }
}
