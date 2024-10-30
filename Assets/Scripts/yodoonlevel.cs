using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yodoonlevel : MonoBehaviour
{
    public bool isPlayingYodo;
    // Start is called before the first frame update
    void Start()
    {
        isPlayingYodo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayingYodo)
        {
            this.gameObject.GetComponent<bannertry>().closeBannerxd();
        }
        else
        {
            this.gameObject.GetComponent<bannertry>().showbannerxd();
        }
    }
    public void isPly()
    {
        isPlayingYodo = !isPlayingYodo;
    }
}
