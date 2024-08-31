using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInstensity : MonoBehaviour
{
    public Material material;
    public int band;
    public float _minIntensity, _maxIntensity;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        material.color = new Color(material.color.r,material.color.g,material.color.b,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity);
    }
}
