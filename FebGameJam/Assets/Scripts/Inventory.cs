using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<int> items = new List<int>();

    public bool zoom = false;
    private int zoomObject;

    public GUISkin mySkin;


    void Start()
    {
        
    }

    void Update()
    {
        // Check for zoom in
        ZoomIn();
    }

    void ZoomIn()
    {
        for(int i = 0; i < items.Count; i++)
        {
            // Check if object is clicked on
            if(false)
            {
                zoom = true;
                zoomObject = i;
            }
        }
    }

    public void AddNewItem(int newItem)
    {
        items.Add(newItem);
    }

    private void OnGUI()
    {
        
        if (zoom)
        {
            GUI.skin = mySkin;
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
            // Use items[zoomObject]
            GUI.DrawTexture(new Rect(Screen.width, Screen.height/2, 50, 50), Texture2D.whiteTexture);
        }

        for(int i = 0; i < items.Count; i++)
        {
            GUI.DrawTexture(new Rect((i * (Screen.width/6)) + (Screen.width/6), 50, 0, 0), Texture2D.whiteTexture);
        }

        for(int i = items.Count; i < 7; i++)
        {
            GUI.skin.box.normal.background = null;
            GUI.Box(new Rect((i * (Screen.width / 6)) + (Screen.width / 12) - 50, Screen.height - 100, 100, 100), "");
        }
    }
}
