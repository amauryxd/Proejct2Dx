using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class secondTypePlayer : MonoBehaviour
{
    public Rigidbody2D plyrb;
    public float upInte;
    public float gravSca;
    void Start()
    {
        plyrb = GetComponent<Rigidbody2D>();
        //plyrb.gravityScale = gravSca;
    }

    // Update is called once per frame
    void Update()
    {
        plyrb.gravityScale = gravSca;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                plyrb.velocity = Vector3.zero;
                plyrb.AddForce(new Vector2(0, upInte),ForceMode2D.Impulse);
            }
        }
    }
}
