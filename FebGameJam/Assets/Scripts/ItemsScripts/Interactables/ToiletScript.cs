using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : InteractableItem
{
    // boolean for if the toilet minigame has been completed
    bool toiletFinished = false;

    public override void Interact()
    {
        base.Interact();

        if (!toiletFinished)
        {
            // make the toilet canvas active and plunger minigame active if they have plunger
            if (GameObject.Find("InventoryManager").GetComponent<Inventory>().HasPlunger())
            {
                
            }
        }
    }
}
