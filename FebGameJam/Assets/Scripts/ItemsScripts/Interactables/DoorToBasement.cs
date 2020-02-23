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

        GameObject.Find("Spy").transform.position = new Vector3(-157.3f, -235.94f, -3f);
        GameObject.Find("Spy").transform.localScale = new Vector3(.9f, .9f, .9f);
    }
}
