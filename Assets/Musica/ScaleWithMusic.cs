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
    void LateUpdate()
    {
        //material.color = new Color(material.color.r,material.color.g,material.color.b,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity);
        if(x && AudioDetect.audioBandBuffer[band] >= 0){
            gameObject.transform.localScale = new Vector3((AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity,gameObject.transform.localScale.y,gameObject.transform.localScale.z);
        }
        if(y && AudioDetect.audioBandBuffer[band] >=0){
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity,gameObject.transform.localScale.z);
        }
        if(z && AudioDetect.audioBandBuffer[band] >=0){
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x,gameObject.transform.localScale.y,(AudioDetect.audioBandBuffer[band]*(_maxIntensity - _minIntensity))+_minIntensity);
        }
    }
}
