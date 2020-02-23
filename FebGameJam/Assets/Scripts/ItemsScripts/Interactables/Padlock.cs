using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Padlock : InteractableItem
{
    string unlockCode = "";
    string input = "";
    int numsInput = 0;
    bool solved = false;
    bool solving = false;

    public GameObject screen;

    public Sprite nuetral;
    public Sprite correct;
    public Sprite incorrect;

    public GameObject textField;

    new void Start()
    {
        base.Start();
        for (int i = 0; i < GameObject.FindGameObjectWithTag("Manager").GetComponent<StartScript>().code.Length; i++)
        {
            unlockCode += GameObject.FindGameObjectWithTag("Manager").GetComponent<StartScript>().code[i] + " ";
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = nuetral;

        screen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!solved && solving)
        {
            //CheckInput();
        }
    }

    public override void Interact()
    {
        base.Interact();
        if(!solving)
        {
            GameObject.FindGameObjectWithTag("MenuBlock").GetComponent<BoxCollider2D>().enabled = true;
            screen.SetActive(true);
            solving = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = nuetral;
        }
    }

    void CheckInput()
    {
        if(unlockCode.Contains(input))
        {
            solved = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = correct;
            BackButton();
            GameManager.Instance.WonGame();
        }
        else if(numsInput == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = incorrect;
            BackButton();
            GameManager.Instance.GameOver();
        }
    }

    public void ClearButton()
    {
        numsInput = 0;
        input = "";
        textField.GetComponent<Text>().text = "";
    }

    public void BackButton()
    {
        ClearButton();
        GameObject.FindGameObjectWithTag("MenuBlock").GetComponent<BoxCollider2D>().enabled = false;
        screen.SetActive(false);
        solving = false;
    }

    public void ButtonPress(int num)
    {
        if(numsInput == 3)
        {
            input += num;
            CheckInput();
            numsInput++;
        }
        else if(numsInput < 3)
        {
            input += num + " ";
            numsInput++;
        }
        textField.GetComponent<Text>().text = input;
    }
}
