using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffdetector : MonoBehaviour
{
    public int band;
    public float _maxIntensity;
    public float _minIntensity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(AudioDetect.audioBandBuffer[band] * (_maxIntensity - _minIntensity) + _minIntensity);
    }
}
