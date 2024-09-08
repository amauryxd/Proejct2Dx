using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselectxd : MonoBehaviour
{
    public void lvl1(){
        SceneManager.LoadScene("forwardtolvl1");
    }
    public void lvl2(){
        SceneManager.LoadScene("Level2");
    }
    public void lvl3(){
        SceneManager.LoadScene("Level3");
    }
}
