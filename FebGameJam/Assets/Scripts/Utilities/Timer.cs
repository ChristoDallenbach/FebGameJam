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
            GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>().GameOver();
        }
    }

    private void OnGUI()
    {
        GUI.skin = mySkin;
        double temp = (timeTotal - currentTime) / 60;
        GUI.Box(new Rect(10, 10, 200, 40), "Time Left: " + Math.Round(temp, (2)));
    }
}
