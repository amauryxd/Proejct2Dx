using System.Collections;
using System;
using System.IO;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    LevelStatus[] lvlstats = new LevelStatus[5];
    public static LevelManager Instance{
        get{
            if(instance == null){
                GameObject levelManager = new GameObject();
                instance = levelManager.AddComponent<LevelManager>();
                levelManager.name = "Level Mangaer Singleton";
            }
            return instance;
        }
    }

    void Awake(){
        if(instance != null && instance != this){
            Destroy(gameObject);
        }else{
            instance=this;
            DontDestroyOnLoad(gameObject);
        }
        try{
            //buscar datos si existen en dado caso que no significa que es la primera vez que lo habren (creo)
            string jsonlvl = readAndroidOrNot();
        }catch{
            lvlstats[0] = new LevelStatus(0,false,0);
            lvlstats[1] = new LevelStatus(1,false,0);
            lvlstats[2] = new LevelStatus(2,false,0);
            string json = JsonHelper.ToJson(lvlstats, true);
            //File.WriteAllText(rute, json);
            writeOnAndroid(json);
        }
    }

    public LevelStatus levelstatus(int id){
        string json = readAndroidOrNot();
        LevelStatus[] lvlread = JsonHelper.FromJson<LevelStatus>(json);
        return lvlread[id];
    }

    public void writeLevelStatus(int id, bool passed, int percentage){
        string jsonread = readAndroidOrNot();
        LevelStatus[] lvlstats = JsonHelper.FromJson<LevelStatus>(jsonread);
        lvlstats[id] = new LevelStatus(id,passed,percentage);
        string jsonwrite = JsonHelper.ToJson(lvlstats,true);
        //File.WriteAllText(rute, jsonwrite);
        writeOnAndroid(jsonwrite);
    }

    public void writeOnAndroid(string jsonwrite)
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            string ruteAndroid = Application.persistentDataPath + "/lvlsts.json";
            File.WriteAllText(ruteAndroid, jsonwrite);
        }
        else
        {
            string rute = Application.dataPath+"/StreamingAssets/lvlsts.json";
            File.WriteAllText(rute,jsonwrite);
        }
    }
    public string readAndroidOrNot()
    {
        string json=null;
        if(Application.platform == RuntimePlatform.Android)
        {
            string ruteAndroid = Application.persistentDataPath + "/lvlsts.json";
            json = File.ReadAllText(ruteAndroid);
        }
        else
        {
            string rute = Application.dataPath+"/StreamingAssets/lvlsts.json";
            json = File.ReadAllText(rute);
        }
        return json;
    }
}

public static class JsonHelper
{
	public static T[] FromJson<T>(string json)
	{
		Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
		return wrapper.Items;
	}
	
	public static string ToJson<T>(T[] array)
	{
		Wrapper<T> wrapper = new Wrapper<T>();
		wrapper.Items = array;
		return JsonUtility.ToJson(wrapper);
	}
	
	public static string ToJson<T>(T[] array, bool prettyPrint)
	{
		Wrapper<T> wrapper = new Wrapper<T>();
		wrapper.Items = array;
		return JsonUtility.ToJson(wrapper, prettyPrint);
	}
	
	[Serializable]
	private class Wrapper<T>
	{
		public T[] Items;
	}
}