using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playericon : MonoBehaviour
{

    public SpriteRenderer playerIcon;
    public Sprite[] icons;
    public int playerStateIcon=0;
    // Start is called before the first frame update
    void Start()
    {
        playerStateIcon=0;
    }

    // Update is called once per frame
    void Update()
    {
        playerIcon.sprite = icons[playerStateIcon];
    }

    public void cambioIcon(int wich){
        playerStateIcon = wich;
    }
}
