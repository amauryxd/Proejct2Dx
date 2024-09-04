using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatChanger : MonoBehaviour
{
    public float defaultsize;
    public float maxSize;

    public bool X;
    public bool Y;
    public bool Z;
    public void sizeBeat(){
        if(X){
            gameObject.transform.localScale = new Vector3(maxSize,0,0);
        }
        if(Y){
            gameObject.transform.localScale = new Vector3(0,maxSize,0);
        }
        if(Z){
            gameObject.transform.localScale = new Vector3(0,0,maxSize);
        }
    }
    public void Start(){
        if(X){
            defaultsize = gameObject.transform.localScale.x;
        }
        if(Y){
            defaultsize = gameObject.transform.localScale.y;
        }
        if(Z){
            defaultsize = gameObject.transform.localScale.z;
        }
    }
    void Update(){
        if(defaultsize < gameObject.transform.localScale.x && X){
            Mathf.Lerp(gameObject.transform.localScale.x, defaultsize, Time.deltaTime);
        }
        if(defaultsize < gameObject.transform.localScale.y && Y){
            Mathf.Lerp(gameObject.transform.localScale.y, defaultsize, Time.deltaTime);
        }
        if(defaultsize < gameObject.transform.localScale.z && Z){
            Mathf.Lerp(gameObject.transform.localScale.z, defaultsize, Time.deltaTime);
        }
    }
}
