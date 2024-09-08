using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forwardlvl1 : MonoBehaviour
{
    public void Awake(){
        SceneManager.LoadScene("Level1");
    }
}
