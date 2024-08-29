using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDEBUG : MonoBehaviour
{

    public Rigidbody2D plyrb;
    public float upInte;
    public float gravSca;

    void Start()
    {
        plyrb = GetComponent<Rigidbody2D>();
        plyrb.gravityScale = gravSca;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Stationary)
            {
                plyrb.AddForce(new Vector2(0, upInte));
            }
        }
    }


}
