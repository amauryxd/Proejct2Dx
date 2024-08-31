using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDetect : MonoBehaviour
{
    public AudioSource lvlmusic;
    public float[] sample = new float[64];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lvlmusic.GetSpectrumData(sample,0,FFTWindow.Blackman);
        
    }
}
