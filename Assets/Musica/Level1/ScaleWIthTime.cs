using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWIthTime : MonoBehaviour
{
    public float scaleSpeed;
    public float limitScale=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(limitScale > gameObject.transform.localScale.y) { 
        gameObject.transform.localScale += new Vector3(0,0+Time.deltaTime*scaleSpeed,0);
        }
    }
}
