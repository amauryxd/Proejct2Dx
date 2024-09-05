using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.Mathematics;

public class cameraShake : MonoBehaviour
{
    public static cameraShake Instance;
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachineBasicMultiChannelPerlin  cinemachineBasicMultiChannelPerlin;
    private float tiempoMovimiento;
    private float tiempoMovimientoTotal;
    private float intensidadInicial;
    private void Awake(){
        Instance = this;
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }
    public void MoverCamara(float intesidad, float frecuencia, float tiempo){
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intesidad;
        cinemachineBasicMultiChannelPerlin.m_FrequencyGain = frecuencia;
        tiempoMovimientoTotal = tiempo;
        tiempoMovimiento = tiempo;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(tiempoMovimiento > 0){
            tiempoMovimiento -= Time.deltaTime;
            cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = Mathf.Lerp(intensidadInicial, 0,1-(tiempoMovimiento/tiempoMovimientoTotal));
        }
    }
}
