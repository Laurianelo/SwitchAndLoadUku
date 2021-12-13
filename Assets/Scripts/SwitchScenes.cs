using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button SwitchSceneBtn = GameObject.FindGameObjectWithTag("SwitchSceneBtn").GetComponent<Button>();
        SwitchSceneBtn.onClick.AddListener(() => OnButtonClick());
    }

    private void OnButtonClick()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.buildIndex ==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
