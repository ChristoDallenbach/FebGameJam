using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopmuterGame : InteractableItem
{
    public GameObject screen;
    public GameObject[] tiles;
    bool inGame = false;
    bool gameWon = false;

    public GameObject cyper;
    int index = 8;

    private new void Start()
    {
        base.Start();
        screen.SetActive(false);
    }

    private void Update()
    {
        if(!gameWon)
        {
            CheckWin();
        }
        else
        {
            for(int i = 0; i < tiles.Length; i++)
            {
                tiles[i].GetComponent<Image>().color = Color.gray;
            }
        }
    }

    public override void Interact()
    {
        base.Interact();
        StartGame();
    }

    void StartGame()
    {
        if(!inGame)
        {
            GameObject.FindGameObjectWithTag("MenuBlock").GetComponent<BoxCollider2D>().enabled = true;
            screen.SetActive(true);
            inGame = true;
        }
    }

    void CheckWin()
    {
        if(inGame)
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                if (tiles[i].GetComponent<Image>().color == Color.black)
                {
                    return;
                }
            }

            gameWon = true;
        }

        if(gameWon)
        {
            // Give Info
            GameObject.Find("InventoryManager").GetComponent<Inventory>().AddNewItem(cyper.GetComponent<GrabableItem>(), index);
        }
    }

    public void ExitButton()
    {
        GameObject.FindGameObjectWithTag("MenuBlock").GetComponent<BoxCollider2D>().enabled = false;
        screen.SetActive(false);
        inGame = false;
    }

    public void ButtonOne()
    {
        if(!gameWon)
        {
            if (tiles[0].GetComponent<Image>().color == Color.white)
            {
                tiles[0].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[0].GetComponent<Image>().color = Color.white;
            }

            if (tiles[3].GetComponent<Image>().color == Color.white)
            {
                tiles[3].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[3].GetComponent<Image>().color = Color.white;
            }

            if (tiles[2].GetComponent<Image>().color == Color.white)
            {
                tiles[2].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[2].GetComponent<Image>().color = Color.white;
            }

            if (tiles[8].GetComponent<Image>().color == Color.white)
            {
                tiles[8].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[8].GetComponent<Image>().color = Color.white;
            }
        }
    }

    public void ButtonTwo()
    {
        if (!gameWon)
        {
            if (tiles[1].GetComponent<Image>().color == Color.white)
            {
                tiles[1].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[1].GetComponent<Image>().color = Color.white;
            }

            if (tiles[3].GetComponent<Image>().color == Color.white)
            {
                tiles[3].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[3].GetComponent<Image>().color = Color.white;
            }

            if (tiles[7].GetComponent<Image>().color == Color.white)
            {
                tiles[7].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[7].GetComponent<Image>().color = Color.white;
            }

            if (tiles[8].GetComponent<Image>().color == Color.white)
            {
                tiles[8].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[8].GetComponent<Image>().color = Color.white;
            }
        }
    }

    public void ButtonThree()
    {
        if (!gameWon)
        {
            if (tiles[4].GetComponent<Image>().color == Color.white)
            {
                tiles[4].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[4].GetComponent<Image>().color = Color.white;
            }

            if (tiles[5].GetComponent<Image>().color == Color.white)
            {
                tiles[5].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[5].GetComponent<Image>().color = Color.white;
            }

            if (tiles[6].GetComponent<Image>().color == Color.white)
            {
                tiles[6].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[6].GetComponent<Image>().color = Color.white;
            }

            if (tiles[2].GetComponent<Image>().color == Color.white)
            {
                tiles[2].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[2].GetComponent<Image>().color = Color.white;
            }
        }
    }

    public void ButtonFour()
    {
        if (!gameWon)
        {
            if (tiles[1].GetComponent<Image>().color == Color.white)
            {
                tiles[1].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[1].GetComponent<Image>().color = Color.white;
            }

            if (tiles[7].GetComponent<Image>().color == Color.white)
            {
                tiles[7].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[7].GetComponent<Image>().color = Color.white;
            }

            if (tiles[4].GetComponent<Image>().color == Color.white)
            {
                tiles[4].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[4].GetComponent<Image>().color = Color.white;
            }

            if (tiles[0].GetComponent<Image>().color == Color.white)
            {
                tiles[0].GetComponent<Image>().color = Color.black;
            }
            else
            {
                tiles[0].GetComponent<Image>().color = Color.white;
            }
        }
    }
}
