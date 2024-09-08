using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdtypeply : MonoBehaviour
{
    public int posIndex;
    public GameObject[] positions;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                if(posIndex==0){
                    posIndex = 1;
                }else if(posIndex ==1){
                    posIndex = 2;
                }else if(posIndex==2){
                    posIndex = 0;
                }
            }
        }
        /*
        switch (posIndex){
            case 0: transform.position = positions[0].transform.position;
                break;
            case 1: transform.position = positions[1].transform.position;
                break;
            case 2: transform.position = positions[2].transform.position;
                break;
        }*/
        if(posIndex==0){
            transform.position = positions[0].transform.position;
        }
        if(posIndex==1){
            transform.position = positions[1].transform.position;
        }
        if(posIndex==2){
            transform.position = positions[2].transform.position;
        }
    }
}
