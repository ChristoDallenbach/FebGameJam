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
    }
}
