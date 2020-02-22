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

    public string code;

    private new void Start()
    {
        base.Start();
        //screen = Instantiate(screen);
        screen.SetActive(false);
    }

    private void Update()
    {
        CheckWin();
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
        }
    }

    public void ExitButton()
    {
        screen.SetActive(false);
        inGame = false;
    }

    public void ButtonOne()
    {
        if(tiles[0].GetComponent<Image>().color == Color.white)
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

    public void ButtonTwo()
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

    public void ButtonThree()
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

    public void ButtonFour()
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
