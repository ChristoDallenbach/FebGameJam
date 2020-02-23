using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFromBathScript : InteractableItem
{
    // camera reference
    [SerializeField] Camera mainCamera;

    public override void Interact()
    {
        base.Interact();

        // move camera towards the main room
        mainCamera.transform.position = new Vector3(-120, -120, -100);

        GameObject.Find("Spy").transform.position = new Vector3(-114f, -121.1f, -3f);
        GameObject.Find("Spy").transform.localScale = new Vector3(.7f, .7f, .7f);
    }
}
