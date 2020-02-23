using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementCabScript : InteractableItem
{
    [SerializeField] private Sprite nextSprite;

    public override void Interact()
    {
        base.Interact();

        if (GameObject.Find("InventoryManager").GetComponent<Inventory>().HasKey())
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite;
            gameObject.transform.GetChild(0).transform.localPosition = new Vector3(gameObject.transform.GetChild(0).transform.localPosition.x, gameObject.transform.GetChild(0).transform.localPosition.y, -.5f);
        }
    }
}
