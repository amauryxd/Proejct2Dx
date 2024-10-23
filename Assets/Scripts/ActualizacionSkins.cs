using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ActualizacionSkins : MonoBehaviour
{
    private static ActualizacionSkins instance;
    SkinStatus[] lvlstats = new SkinStatus[5];
    public List<Sprite> sprites = new List<Sprite>();
    public static ActualizacionSkins Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject levelManager = new GameObject();
                instance = levelManager.AddComponent<ActualizacionSkins>();
                levelManager.name = "Skins Manger Singleton";
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
            lvlstats[0] = new SkinStatus(0, sprites[0], true);
            lvlstats[1] = new SkinStatus(1, sprites[1], false);
            lvlstats[2] = new SkinStatus(2, sprites[2], false);
            lvlstats[3] = new SkinStatus(3, sprites[3], false);
            lvlstats[4] = new SkinStatus(4, sprites[4], false);
            string json = JsonHelper.ToJson(lvlstats, false);
            //File.WriteAllText(rute, json);
            writeOnAndroid(json);
        }


    }

    public string readAndroidOrNot()
    {
        string json = null;
        if (Application.platform == RuntimePlatform.Android)
        {
            string ruteAndroid = Application.persistentDataPath + "/sksts.json";
            json = File.ReadAllText(ruteAndroid);
        }
        else
        {
            string rute = Application.dataPath + "/StreamingAssets/sksts.json";
            json = File.ReadAllText(rute);
        }
        return json;
    }
    public SkinStatus SkinStatus(int id)
    {
        string json = readAndroidOrNot();
        SkinStatus[] lvlread = JsonHelper.FromJson<SkinStatus>(json);
        return lvlread[id];
    }

    public void writeSkinStatus(int id, Sprite sprite, bool unlocked)
    {
        string jsonread = readAndroidOrNot();
        SkinStatus[] lvlstats = JsonHelper.FromJson<SkinStatus>(jsonread);
        lvlstats[id] = new SkinStatus(id, sprite, unlocked);
        string jsonwrite = JsonHelper.ToJson(lvlstats, true);
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