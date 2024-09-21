using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metaWriteJson : MonoBehaviour
{
    public void metaPass(){
        LevelManager.Instance.writeLevelStatus(GameManager.cualescena(),true,100);
    }
}
