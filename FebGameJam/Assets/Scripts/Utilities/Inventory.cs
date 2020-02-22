using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int MAX_ITEMS = 8;
    // (0-4 Code Snippits, 5-Plunger, 6-Life Preserver, 7-Key )
    private GrabableItem[] items = new GrabableItem[MAX_ITEMS];

    public bool zoom = false;
    private int zoomObject;

    public GUISkin mySkin;

    private Texture2D[] objectTextures = new Texture2D[MAX_ITEMS];

    public void AddNewItem(GrabableItem newItem, int placement) // Adds items to the list
    {
        Debug.Log("hooplah");
        items[placement] = newItem;

        Texture2D temp = new Texture2D((int)items[placement].objectTexture.textureRect.width, (int)items[placement].objectTexture.textureRect.height);
        Color[] pixels = items[placement].objectTexture.texture.GetPixels((int)items[placement].objectTexture.textureRect.x, (int)items[placement].objectTexture.textureRect.y, (int)items[placement].objectTexture.textureRect.width, (int)items[placement].objectTexture.textureRect.height);
        temp.SetPixels(pixels);
        temp.Apply();
        objectTextures[placement] = temp;
        temp = null;
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
                    if (GUI.Button(new Rect(Screen.width - 100, (i * (Screen.height / MAX_ITEMS)) + (Screen.height / (MAX_ITEMS * 2)) - 40, 80, 80), objectTextures[i]))
                    {
                        zoom = true;
                        zoomObject = i;
                    }
                }
                // Makes buttons that do nothing when clicked for the empty spaces left over
                else
                {
                    GUI.Button(new Rect(Screen.width - 100, (i * (Screen.height / MAX_ITEMS)) + (Screen.height / (MAX_ITEMS * 2)) - 40, 80, 80), "");
                }
            }

            //for (int i = items.Count; i < MAX_ITEMS; i++) // Makes buttons that do nothing when clicked for the empty spaces left over
            //{
            //    
            //}
        }
    }

    // (0-4 Code Snippits, 5-Plunger, 6-Life Preserver, 7-Key )
    public bool HasKey()
    {
        if(items[7] != null)
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
        if(items[6] != null)
        {
            return true;
        }
        return false;
    }
}
