using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musik : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clipQueue; //Lista med låtar - Leo
    int currentSong = 0;  //Börjar på låt 1 - Leo

    private void Start()
    {
        audioSource.Play(); //Spelar låten - Leo
    }

    void Update()
    {
        if (audioSource.isPlaying == false) //Om ingenting spelas - Leo
        {
            currentSong++; //spela nästa låt - Leo
            if (currentSong == clipQueue.Length) //Om vid slutet av listan - Leo
            {
                currentSong = 0; //spela första låten - Leo
            }


            audioSource.clip = clipQueue[currentSong];
            audioSource.Play();
        }
    }

}
