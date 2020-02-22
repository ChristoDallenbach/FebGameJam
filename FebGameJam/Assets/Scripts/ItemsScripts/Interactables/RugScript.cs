using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugScript : InteractableItem
{
    public override void Interact()
    {
        base.Interact();

        placeToPlace.transform.position = new Vector3(placeToPlace.transform.position.x - 4f, placeToPlace.transform.position.y - 2f, placeToPlace.transform.position.z);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 4f, gameObject.transform.position.y + 2f, gameObject.transform.position.z);       
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
