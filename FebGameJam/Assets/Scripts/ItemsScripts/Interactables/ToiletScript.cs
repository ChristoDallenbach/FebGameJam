using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletScript : InteractableItem
{
    // boolean for if the toilet minigame has been completed
    bool toiletFinished = false;
    [SerializeField] private GameObject toiletGame;

    public override void Interact()
    {
        base.Interact();
        GameObject.FindGameObjectWithTag("MenuBlock").GetComponent<BoxCollider2D>().enabled = true;
        if (!toiletFinished)
        {
            toiletGame.SetActive(true);
            // make the toilet canvas active and plunger minigame active if they have plunger
            if (GameObject.Find("InventoryManager").GetComponent<Inventory>().HasPlunger())
            {
                toiletGame.GetComponent<Plunger>().HasPlunger();
            }
        }
    }
}
