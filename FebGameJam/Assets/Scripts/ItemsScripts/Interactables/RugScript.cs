using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugScript : InteractableItem
{
    [SerializeField] private GameObject placeToPlace;

    public override void Interact()
    {
        base.Interact();

        placeToPlace.transform.position = new Vector3(placeToPlace.transform.position.x - 3f, placeToPlace.transform.position.y - 1f, placeToPlace.transform.position.z);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 3f, gameObject.transform.position.y + 1f, gameObject.transform.position.z);       
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
