using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anotherscalewithtime : MonoBehaviour
{
    public float scaleSpeed;
    public float limitScale;

    public bool X;
    public bool Y;
    public bool Z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(X && limitScale > gameObject.transform.localScale.x)
            gameObject.transform.localScale = new Vector3(transform.localScale.x+Time.deltaTime*scaleSpeed,transform.localScale.y,transform.localScale.z);
        
        if(Y && limitScale > gameObject.transform.localScale.y)
            gameObject.transform.localScale = new Vector3(transform.localScale.x,transform.localScale.y+Time.deltaTime*scaleSpeed,transform.localScale.z);

        if(Z && limitScale > gameObject.transform.localScale.z)
            gameObject.transform.localScale = new Vector3(transform.localScale.x,transform.localScale.y, transform.localScale.z+Time.deltaTime*scaleSpeed);
    }
}
