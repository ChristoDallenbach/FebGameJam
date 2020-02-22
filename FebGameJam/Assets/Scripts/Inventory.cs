using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<int> items = new List<int>();
    private const int MAX_ITEMS = 6;

    public bool zoom = false;
    private int zoomObject;

    public GUISkin mySkin;

    void Start()
    {
        items.Add(2);
        items.Add(230);
    }

    public void AddNewItem(int newItem) // Adds items to the list
    {
        items.Add(newItem);
    }

    private void OnGUI()
    {
        GUI.skin = mySkin;
        if (zoom) // Draws the zoomed in object
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
            // Display Item and other info
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 50, 50), items[zoomObject] + "");
            // Display text that describes the object maybe

            if(Input.GetMouseButtonDown(1)) // Right click to un-zoom
            {
                zoom = false;
            }
        }
        else // Draws the other items and blank spots if not zoomed in
        {

            for (int i = 0; i < items.Count; i++) // Makes buttons that do something when clicked for items that currently exist
            {
                if (GUI.Button(new Rect(Screen.width - 100, (i * (Screen.height / MAX_ITEMS)) + (Screen.height / (MAX_ITEMS * 2)) - 50, 100, 100), items[i] + ""))
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
