using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemScript : MonoBehaviour
{
    public abstract void Interact();

    public void OnMouseDown()
    {
        Interact();
    }
}
