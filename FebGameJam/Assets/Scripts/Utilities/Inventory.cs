using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int MAX_ITEMS = 8;
    // (0-Key, 1-Laptop Password, 2-5 Code Snippits, 6-Plunger, 7-Life Preserver)
    private GrabableItem[] items = new GrabableItem[MAX_ITEMS];

    public bool zoom = false;
    private int zoomObject;

    public GUISkin mySkin;

    public void AddNewItem(GrabableItem newItem, int placement) // Adds items to the list
    {
        Debug.Log("hooplah");
        items[placement] = newItem;
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

            for (int i = 0; i < MAX_ITEMS; i++) // Makes buttons that do something when clicked for items that currently exist
            {
                if (items[i] != null)
                {
                    if (GUI.Button(new Rect(Screen.width - 100, (i * (Screen.height / MAX_ITEMS)) + (Screen.height / (MAX_ITEMS * 2)) - 50, 100, 100), items[i].objectTexture.texture))
                    {
                        zoom = true;
                        zoomObject = i;
                    }
                }
                // Makes buttons that do nothing when clicked for the empty spaces left over
                else
                {
                    GUI.Button(new Rect(Screen.width - 100, (i * (Screen.height / MAX_ITEMS)) + (Screen.height / (MAX_ITEMS * 2)) - 50, 100, 100), "");
                }
            }

            //for (int i = items.Count; i < MAX_ITEMS; i++) // Makes buttons that do nothing when clicked for the empty spaces left over
            //{
            //    
            //}
        }
    }

    // (0-Key, 1-Laptop Password, 2-5 Code Snippits, 6-plunger)
    public bool HasKey()
    {
        if(items[0] != null)
        {
            return true;
        }
        return false;
    }
    public bool HasPassword()
    {
        if (items[1] != null)
        {
            return true;
        }
        return false;
    }
    public bool HasPlunger()
    {
        if (items[6] != null)
        {
            return true;
        }
        return false;
    }
    public bool HasPreserver()
    {
        if(items[7] != null)
        {
            return true;
        }
        return false;
    }
}
