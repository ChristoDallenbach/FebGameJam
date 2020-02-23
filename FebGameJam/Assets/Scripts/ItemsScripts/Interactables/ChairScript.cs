using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript : InteractableItem
{
    [SerializeField] private Sprite spyStanding;
    public bool isStanding = false;
    public override void Interact()
    {
        base.Interact();

        GameObject.Find("Spy").GetComponent<SpriteRenderer>().sprite = spyStanding;
        GameObject.Find("Spy").transform.position = new Vector3(-157.3f, -235.94f, -3f);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        isStanding = true;
    }
}
