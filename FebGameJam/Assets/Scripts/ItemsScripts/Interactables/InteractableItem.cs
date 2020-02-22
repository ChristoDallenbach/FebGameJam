using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : ItemScript
{
    // boolean for if it is holding something
    public bool isHolding;
    protected GameObject instantiatedObject;
    [SerializeField] public GameObject placeToPlace;

    protected void Start()
    {
        isHolding = false;
    }

    // method called when player interacts with the object
    public override void Interact()
    {
        
    }

    // method to place the object in world space
    public void PlaceObject(GameObject prefab, int index)
    {
        // itemToPlace (0-Key, 1-Laptop Password, 2-5 Code Snippits, 6-plunger)
        instantiatedObject = Instantiate(prefab, gameObject.GetComponentInChildren<Transform>());
        instantiatedObject.transform.parent = placeToPlace.transform;
        instantiatedObject.transform.localPosition = new Vector3(0, 0, .1f);
        instantiatedObject.GetComponent<GrabableItem>().index = index;
    }
}
