using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BPMEvents : MonoBehaviour
{
    [SerializeField] private float bpm;
    [SerializeField] private Intervals[] intervals;

    private void Update(){
        foreach(Intervals interval in intervals){
            float sampledTime = (AudioDetect.audioSource.timeSamples / (AudioDetect.audioSource.clip.frequency * interval.GetIntervalLength(bpm)));
            interval.CheckForNewInterval(sampledTime);
        }
    }
}

[System.Serializable]
public class Intervals{
    [SerializeField] private float steps;
    [SerializeField] private UnityEvent trigger;
    private int lastInterval;

    public float GetIntervalLength(float bpm){
        return 60f / (bpm * steps);
    }
    public void CheckForNewInterval(float interval){

        if(Mathf.FloorToInt(interval) != lastInterval) {
            lastInterval = Mathf.FloorToInt(interval);
            trigger.Invoke();
        }
    }
}