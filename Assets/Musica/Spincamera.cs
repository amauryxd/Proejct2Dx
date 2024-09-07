using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Spincamera : MonoBehaviour
{
    public CinemachineVirtualCamera camaraxd;
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void movingdutch(){
        camaraxd.m_Lens.Dutch = Mathf.Lerp(0,180,Time.deltaTime*rotatespeed);
    }
    public void regresardutch(){
        camaraxd.m_Lens.Dutch = Mathf.Lerp(180,0,Time.deltaTime*rotatespeed);
    }
}
