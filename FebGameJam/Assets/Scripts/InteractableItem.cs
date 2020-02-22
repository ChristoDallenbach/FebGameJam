using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : ItemScript
{
    // boolean for if it is holding something
    public bool isHolding;

    void Start()
    {
        isHolding = false;
    }

    // method called when player interacts with the object
    public override void Interact()
    {
        
    }

    // method to place the object in world space
    public void PlaceObject(GameObject prefab)
    {
        // itemToPlace (0-Key, 1-Laptop Password, 2-5 Code Snippits
        Instantiate(prefab, gameObject.GetComponentInChildren<Transform>());  
    }
}
