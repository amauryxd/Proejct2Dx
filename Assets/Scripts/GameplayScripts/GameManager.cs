using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float LevelSpeed;
    public static bool playerLive;
    public int contEvitar;
    // Start is called before the first frame update
    void Start()
    {
        LevelMov.movSpeed = LevelSpeed;
        playerLive = true;
        contEvitar = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerLive)
        {
            evitarE();
        }
    }
    public void resetSPeed()
    {
        LevelMov.movSpeed = LevelSpeed;
    }
    public static void death()
    {
        GameObject ply;
        ply = GameObject.FindGameObjectWithTag("Player");
        Destroy(ply);
        playerLive = false;
    }
    public void evitarE()
    {
        

        if(contEvitar== 0)
        {
            contEvitar= 1;
            StartCoroutine(reinicio(SceneManager.GetActiveScene().buildIndex));
        }
    }
    public static IEnumerator reinicio(int sceneCount)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(sceneCount);
    }
    public void PauseOnDeath()
    {

        if (!playerLive)
        {
            StopAllCoroutines();

        }
        
    }
    public void ContinueOnDeath()
    {
        if (!playerLive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
