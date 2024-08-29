using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMov : MonoBehaviour
{
    public static float movSpeed;

    void Update()
    {
        gameObject.transform.position += new Vector3(-1,0,0) * movSpeed * Time.deltaTime;
    }
}
