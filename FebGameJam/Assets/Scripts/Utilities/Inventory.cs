using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<GrabableItem> items = new List<GrabableItem>();
    private const int MAX_ITEMS = 6;

    public bool zoom = false;
    private int zoomObject;

    public bool hasKey = false;

    public GUISkin mySkin;

    public void AddNewItem(GrabableItem newItem) // Adds items to the list
    {
        Debug.Log("hooplah");
        items.Add(newItem);
    }

    public void AddNewItem(GrabableItem newItem, bool key) // Adds items to the list
    {
        items.Add(newItem);
        hasKey = true;
    }

    private void OnGUI()
    {
        GUI.skin = mySkin;
        if (zoom) // Draws the zoomed in object
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");

            // Display Item and other info
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 200), items[zoomObject].objectTexture.texture);
            // Display text that describes the object maybe

            if(GUI.Button(new Rect(0, 0, 100, 100), "Back")) // Right click to un-zoom
            {
                zoom = false;
            }
        }
        else // Draws the other items and blank spots if not zoomed in
        {

            for (int i = 0; i < items.Count; i++) // Makes buttons that do something when clicked for items that currently exist
            {
                if (GUI.Button(new Rect(Screen.width - 100, (i * (Screen.height / MAX_ITEMS)) + (Screen.height / (MAX_ITEMS * 2)) - 50, 100, 100), items[zoomObject].objectTexture.texture))
                {
                    zoom = true;
                    zoomObject = i;
                }
            }

            for (int i = items.Count; i < MAX_ITEMS; i++) // Makes buttons that do nothing when clicked for the empty spaces left over
            {
                GUI.Button(new Rect(Screen.width - 100, (i * (Screen.height / MAX_ITEMS)) + (Screen.height / (MAX_ITEMS * 2)) - 50, 100, 100), "");
            }
        }
    }
}
