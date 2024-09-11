using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class percentAdvance : MonoBehaviour
{
    public GameObject levelxd;
    public TextMeshProUGUI cajatext;
    int porciento;
    public float LimitLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        porciento = Mathf.Clamp(Mathf.RoundToInt((levelxd.transform.position.x*-100)/LimitLevel),0,100);
        cajatext.text = porciento.ToString();

    }
}
