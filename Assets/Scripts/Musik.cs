using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musik : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clipQueue; //Lista med l�tar - Leo
    int currentSong = 0;  //B�rjar p� l�t 1 - Leo

    private void Start()
    {
        audioSource.Play(); //Spelar l�ten - Leo
    }

    void Update()
    {
        if (audioSource.isPlaying == false) //Om ingenting spelas - Leo
        {
            currentSong++; //spela n�sta l�t - Leo
            if (currentSong == clipQueue.Length) //Om vid slutet av listan - Leo
            {
                currentSong = 0; //spela f�rsta l�ten - Leo
            }


            audioSource.clip = clipQueue[currentSong];
            audioSource.Play();
        }
    }

}
