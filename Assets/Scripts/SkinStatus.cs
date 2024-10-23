using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinStatus
{
    public int id;
    public Sprite Sprite;
    public bool unlocked;

    public SkinStatus(int id, Sprite sprite, bool unlocked)
    {
        this.id = id;
        Sprite = sprite;
        this.unlocked = unlocked;
    }
}
