using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToBasement : InteractableItem
{
    // camera reference
    [SerializeField] Camera mainCamera;

    public override void Interact()
    {
        base.Interact();

        // move camera to bathroom
        mainCamera.transform.position = new Vector3(-160, -230, -100);
    }
}
