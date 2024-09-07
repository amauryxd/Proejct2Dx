using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboRotate : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(x,y,z));
    }
}
