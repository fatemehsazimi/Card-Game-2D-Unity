using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicOnOrOffBtn : MonoBehaviour
{
    
    public void playMusic()
    
    {
         AudioSource[] audios = FindObjectsOfType<AudioSource>();
         foreach (AudioSource a in audios)
         {
            a.Play();
         }
    }

    public void pauseMusic()
    
    {
         AudioSource[] audios = FindObjectsOfType<AudioSource>();
         foreach (AudioSource a in audios)
         {
            a.Pause();
         }
    }

   
}
