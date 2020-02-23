using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float currentTime = 0;
    float timeTotal = 600;

    public GUISkin mySkin;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= timeTotal)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }

    private void OnGUI()
    {
        GUI.skin = mySkin;
        double temp = (timeTotal - currentTime);
        int seconds = (int)temp % 60;
        string secStr = seconds.ToString();
        if(seconds < 10) { secStr = "0" + secStr; }
        int minutes = (int)temp / 60;
        GUI.Box(new Rect(10, 10, 200, 100), minutes + ":" + secStr);
    }
}
