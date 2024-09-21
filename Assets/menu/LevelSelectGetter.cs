using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelSelectGetter : MonoBehaviour
{
    private LevelStatus stats;
    public int id;
    public TextMeshProUGUI percentage;
    public Toggle checkmark;
    void Awake(){
        stats = LevelManager.Instance.levelstatus(id);
    }
    void OnEnable()
    {
        stats = LevelManager.Instance.levelstatus(id);
        percentage.text = stats.percentage.ToString();
        checkmark.isOn = stats.passed;
    }
}
