using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableItem : ItemScript
{
    // sprite for drawing to inventory
    public Sprite objectTexture;
    // (0-Key, 1-Laptop Password, 2-5 Code Snippits, 6-plunger)
    public int index;

    // put item into empty inventory spot
    public override void Interact()
    {
        Debug.Log("scoop");
        // getting the sprite for drawing in inventory
        objectTexture = gameObject.GetComponent<SpriteRenderer>().sprite;

        // get the inventory manager   
        GameObject.Find("InventoryManager").GetComponent<Inventory>().AddNewItem(this, index);

        // destroy the gameobject
        //Destroy(gameObject);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
