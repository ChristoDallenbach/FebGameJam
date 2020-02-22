using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // array of all the interactable objects
    [SerializeField] private GameObject[] interactableObjects;
    public int[] code;
    [SerializeField] public GameObject[] prefabs = new GameObject[5];
    [SerializeField] private GameObject plungerGame;
    public Sprite[] noteSprites;

    // Start is called before the first frame update
    void Start()
    {
        // getting all the interactable objects
        interactableObjects = GameObject.FindGameObjectsWithTag("Interactables");

        // setting code length
        code = new int[4];

        // randomizing the room
        RandomizeRoom();
    }

    // method to randomize where the code is placed in the room
    private void RandomizeRoom()
    {
        // randomizing the code
        RandomizeCode();

        int i = 0;


        // loop for all the objects that are needed to place
        while(i<4)
        {
            // get a random number from the length of the array
            int randomNumber = Random.Range(0, interactableObjects.Length);
        
            // check if the object is available to hold an item i.e. if the item is taken already
            if (interactableObjects[randomNumber].GetComponent<InteractableItem>().isHolding == true)
            {
                continue;
            }
        
            // place the object on the item
            interactableObjects[randomNumber].GetComponent<InteractableItem>().PlaceObject(prefabs[i], i);
        
            // mark the item as checked
            interactableObjects[randomNumber].GetComponent<InteractableItem>().isHolding = true;
        
            // increamenting the loop
            i++;
        }

        // placing the key either in the toilet or in a random spot
        int keyInToilet = Random.Range(0, 1);
        if (keyInToilet == 0)
        {
            plungerGame.GetComponent<Plunger>().HasGoodReward();
            i++;
        }
        else
        {
            GameObject.Find("Rug").GetComponent<InteractableItem>().PlaceObject(prefabs[i], i);
            GameObject.Find("Rug").GetComponent<InteractableItem>().isHolding = true;
            i++;
        }

    }

    // code to randomize what the code is
    private void RandomizeCode()
    {
        // picking a random one-length number to use as a part of the code
        for(int i = 0; i<4; i++)
        {
            int temp = Random.Range(0, 9);
            code[i] = temp;

            switch (temp)
            {
                case 0:
                    prefabs[i].GetComponent<SpriteRenderer>().sprite = noteSprites[i * 10 + 7];
                    break;

                case 1:
                    prefabs[i].GetComponent<SpriteRenderer>().sprite = noteSprites[i * 10 + 8];
                    break;

                case 2:
                    prefabs[i].GetComponent<SpriteRenderer>().sprite = noteSprites[i * 10 + 9];
                    break;

                default:
                    prefabs[i].GetComponent<SpriteRenderer>().sprite = noteSprites[i * 10 + temp - 3] ;
                    break;
            }

            prefabs[i].transform.localScale = new Vector2(0.5f, 0.5f);
        }
    }
}
