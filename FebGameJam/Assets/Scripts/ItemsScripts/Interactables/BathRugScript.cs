using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathRugScript : InteractableItem
{
    public override void Interact()
    {
        base.Interact();

        placeToPlace.transform.position = new Vector3(placeToPlace.transform.position.x - 5f, placeToPlace.transform.position.y, placeToPlace.transform.position.z);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 5f, gameObject.transform.position.y, gameObject.transform.position.z);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
