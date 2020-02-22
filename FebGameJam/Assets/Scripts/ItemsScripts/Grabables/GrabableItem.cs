using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableItem : ItemScript
{
    // sprite for drawing to inventory
    public Sprite objectTexture;

    // put item into empty inventory spot
    public override void Interact()
    {
        Debug.Log("scoop");
        // getting the sprite for drawing in inventory
        objectTexture = gameObject.GetComponent<SpriteRenderer>().sprite;

        // get the inventory manager   
        GameObject.Find("InventoryManager").GetComponent<Inventory>().AddNewItem(this);

        // destroy the gameobject
        Destroy(gameObject);
    }
}
