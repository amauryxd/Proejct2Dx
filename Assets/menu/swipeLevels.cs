using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class swipeLevels : MonoBehaviour
{
    public GameObject scrollbar;
    float scroll_pos = 0;
    float[] pos;
    public Material fondoxd;
    public GameObject camara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f/(pos.Length-1);
        for(int i = 0; i < pos.Length; i++){
            pos[i] = distance*i;
        }
        if(Input.GetMouseButton(0)){
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }else{
            for(int i = 0; i < pos.Length; i++){
                if(scroll_pos < pos[i]+(distance/2)&&scroll_pos > pos[i] - (distance/2)){
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value,pos[i],0.1f);
                    switch(pos[i]){
                case 0: camara.GetComponent<Camera>().backgroundColor = new Color(0.5900409f,0.04917233f,0.8018868f);
                        fondoxd.color = new Color(0.8888397f,0.1635368f,0.990566f);
                    break;
                case 0.5f: camara.GetComponent<Camera>().backgroundColor = new Color(0.6792453f,0,0.04382224f);
                        fondoxd.color=new Color(0.9811321f,0.6066245f,0.3008188f);
                    break;
                case 1: camara.GetComponent<Camera>().backgroundColor = new Color(0,0.488f,0.8245835f);
                        fondoxd.color= new Color(0.2122642f,0.6264187f,1);
                    break;
                default: Debug.LogWarning("Porq???");
                    break;
                    }
                }
            }
        }
    }

    public void cameracolorreset(){
        camara.GetComponent<Camera>().backgroundColor = new Color(0,0,0);
    }
}
