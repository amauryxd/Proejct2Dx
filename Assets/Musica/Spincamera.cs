using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Spincamera : MonoBehaviour
{
    public Animator animationcam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void movingdutch(){
        animationcam.SetTrigger("camrotate");
    }
    public void regresardutch(){
        animationcam.SetTrigger("descamrotate");
    }
}
