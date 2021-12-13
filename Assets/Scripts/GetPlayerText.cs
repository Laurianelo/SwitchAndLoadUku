using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerText : MonoBehaviour
{
    private string txtInput;

    public void ReadInput(string s)
    {
        txtInput = s;
        SaveAndLoadData.Instance.SaveData(s);
    }

}
