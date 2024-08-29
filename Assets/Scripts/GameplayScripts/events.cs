using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class events : MonoBehaviour
{
    public UnityEvent eventoxd = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        eventoxd.Invoke();
        }
    }
}
