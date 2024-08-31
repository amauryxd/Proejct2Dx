using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
        LevelMov.movSpeed = 0;
        GameManager.death();
        MusicaPausa.MusicStop();
        Debug.Log(gameObject.name);
        }
    }
}
