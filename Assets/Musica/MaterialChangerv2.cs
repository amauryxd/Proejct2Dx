using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangerv2 : MonoBehaviour
{
    public Material material;
    public int band;

    public bool canalRed;
    public bool canalGreen;
    public bool canalBlue;
    public bool canalAlpha;

    public float _minIntensity, _maxIntensity;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(canalAlpha)
        material.color = new Color(material.color.r,material.color.g,material.color.b,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity);

        if(canalRed)
        material.color = new Color((AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity,material.color.g,material.color.b,material.color.a);

        if(canalGreen)
        material.color = new Color(material.color.r,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity,material.color.b,material.color.a);

        if(canalBlue)
        material.color = new Color(material.color.r,material.color.g,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity,material.color.a);
    }
}
