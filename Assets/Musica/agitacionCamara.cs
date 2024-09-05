using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agitacionCamara : MonoBehaviour
{
    public float intensidad;
    public float frecuencia;
    public float tiempo;
    public void Agitar(){
        cameraShake.Instance.MoverCamara(intensidad, frecuencia,tiempo);
        Debug.Log("?");
    }
}
