using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(1, 0, 0) * LevelMov.movSpeed * Time.deltaTime;
    }
}
