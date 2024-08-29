using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public void ExitP()
    {
        SceneManager.LoadScene("LevelSelecto");
    }

    public void RestartP()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PuaseLevelVEL()
    {
        LevelMov.movSpeed = 0;
    }

}
