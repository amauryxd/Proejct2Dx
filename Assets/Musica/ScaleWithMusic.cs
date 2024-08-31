using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWithMusic : MonoBehaviour
{
    public int band;
    public float _minIntensity, _maxIntensity;
    
    public bool x;
    public bool y;
    public bool z;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //material.color = new Color(material.color.r,material.color.g,material.color.b,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity);
        if(x){
            gameObject.transform.localScale = new Vector3((AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity,1,1);
        }
        if(y){
            gameObject.transform.localScale = new Vector3(1,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity,1);
        }
        if(z){
            gameObject.transform.localScale = new Vector3(1,1,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity);
        }
    }
}
