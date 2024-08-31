using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicaPausa : MonoBehaviour
{
    public static AudioSource musica;

    public void Start(){
        musica = GetComponent<AudioSource>();
    }

    public static void MusicStop(){
        musica.Stop();
    }
    public void botonMusicaPause(){
        musica.Pause();
    }
    public void MusicContinue(){
        musica.UnPause();
    }
}
