using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondocolorreset : MonoBehaviour
{
    public Material colorxd;
    void Start()
    {
        colorestart();
    }

    public void colorestart(){
        colorxd.color = new Color(0,0.1896417f,1);
    }
}
