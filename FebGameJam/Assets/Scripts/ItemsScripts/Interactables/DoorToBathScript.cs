using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToBathScript : InteractableItem
{
    // camera reference
    [SerializeField] Camera mainCamera;

    public override void Interact()
    {
        base.Interact();

        // move camera to bathroom
        mainCamera.transform.position = new Vector3(-131, 25, -100);

        GameObject.Find("Spy").transform.position = new Vector3(-123f, 16.7f, -3f);
        GameObject.Find("Spy").transform.localScale = new Vector3(.7f, .7f, .7f);
    }
}
