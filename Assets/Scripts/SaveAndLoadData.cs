using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveAndLoadData : MonoBehaviour
{


    private string txtInput;
    private static SaveAndLoadData _instance;

    public static SaveAndLoadData Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    //playerpref : quick solution for test
    //but it's better with Json for exemeple
    public void SaveData(string data)
    {
        PlayerPrefs.SetString("TextInput", data);
    }

    public string LoadData()
    {
       return PlayerPrefs.GetString("TextInput", "");
    }
}
