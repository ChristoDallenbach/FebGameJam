using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedBookGame : InteractableItem
{
    public GameObject screen;
    public GameObject[] tiles;
    bool inGame = false;
    bool gameWon = false;

    new void Start()
    {
        base.Start();
        screen.SetActive(false);
    }

    public override void Interact()
    {
        base.Interact();
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameWon)
        {
            CheckWin();
        }
        else
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i].GetComponent<Image>().color = Color.gray;
            }
        }
    }

    void StartGame()
    {
        if (!inGame)
        {
            GameObject.FindGameObjectWithTag("MenuBlock").GetComponent<BoxCollider2D>().enabled = true;
            screen.SetActive(true);
            inGame = true;
        }
    }

    void CheckWin()
    {
        if (inGame)
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                if (tiles[i].transform.localEulerAngles.z != 180)
                {
                    return;
                }
            }

            gameWon = true;
        }

        if (gameWon)
        {
            Debug.Log("win");
            instantiatedObject.GetComponent<GrabableItem>().Interact();
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
            tiles[0].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
            tiles[3].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
            tiles[6].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
        }
    }

    public void ButtonTwo()
    {
        if (!gameWon)
        {
            tiles[7].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
            tiles[1].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
            tiles[8].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
        }      
    }

    public void ButtonThree()
    {
        if (!gameWon)
        {
            tiles[5].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
            tiles[3].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
            tiles[0].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
        }
    }

    public void ButtonFour()
    {
        if (!gameWon)
        {
            tiles[1].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
            tiles[8].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
            tiles[4].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
        }
    }

    public void ButtonFive()
    {
        if (!gameWon)
        {
            tiles[2].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
            tiles[5].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
            tiles[6].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 90));
        }      
    }

    public void ButtonSix()
    {
        if (!gameWon)
        {
            tiles[5].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
            tiles[7].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
            tiles[4].GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -90));
        }
    }
}
