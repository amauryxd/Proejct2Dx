using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CameraActivateEvent : MonoBehaviour
{
    public UnityEvent eventocubo = new UnityEvent();

    private void OnBecameInvisible(){

    }

    private void OnBecameVisible(){
        eventocubo.Invoke();
    }
}
