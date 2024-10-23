using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CualSkin : MonoBehaviour
{
    private static CualSkin instance;
    public skin skin;
    public static CualSkin Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject levelManager = new GameObject();
                instance = levelManager.AddComponent<CualSkin>();
                levelManager.name = "skin Singleton";
            }
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        try
        {
            //buscar datos si existen en dado caso que no significa que es la primera vez que lo habren (creo)
            string jsonlvl = readAndroidOrNot();
        }
        catch
        {
            skin = new skin(1);
            string json = JsonUtility.ToJson(skin, false);
            writeOnAndroid(json);
        }


    }

    public string readAndroidOrNot()
    {
        string json = null;
        if (Application.platform == RuntimePlatform.Android)
        {
            string ruteAndroid = Application.persistentDataPath + "/sk.json";
            json = File.ReadAllText(ruteAndroid);
        }
        else
        {
            string rute = Application.dataPath + "/StreamingAssets/sk.json";
            json = File.ReadAllText(rute);
        }
        return json;
    }
    public int cual()
    {
        string json = readAndroidOrNot();
        skin skins = JsonUtility.FromJson<skin>(json);
        return skins.id;
    }

    public void writeSkin(int id)
    {
        string jsonread = readAndroidOrNot();
        skin skinread = JsonUtility.FromJson<skin>(jsonread);
        skinread = new skin(id);
        string jsonwrite = JsonUtility.ToJson(skinread, true);
        //File.WriteAllText(rute, jsonwrite);
        writeOnAndroid(jsonwrite);
    }

    public void writeOnAndroid(string jsonwrite)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            string ruteAndroid = Application.persistentDataPath + "/lvlsts.json";
            File.WriteAllText(ruteAndroid, jsonwrite);
        }
        else
        {
            string rute = Application.dataPath + "/StreamingAssets/lvlsts.json";
            File.WriteAllText(rute, jsonwrite);
        }
    }
}
