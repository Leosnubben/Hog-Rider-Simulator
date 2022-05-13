using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musik : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clipQueue;
    int currentSong = 0;

    void Update()
    {
        if (audioSource.isPlaying == false)
        {
            currentSong++;
            if (currentSong == clipQueue.Length)
            {
                currentSong = 0;
            }


            audioSource.clip = clipQueue[currentSong];
            audioSource.Play();
        }
    }

}
