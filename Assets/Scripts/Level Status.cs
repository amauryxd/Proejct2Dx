using System;
using UnityEngine;
[Serializable]
public class LevelStatus
{
    public int id;
    public bool passed;
    public int percentage;

    public LevelStatus(int id, bool passed, int percentage){
        this.id = id;
        this.passed = passed;
        this.percentage = percentage;
    }
}
