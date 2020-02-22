﻿using System.Collections;
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
        for (int i = 1; i < GameObject.FindGameObjectWithTag("Manager").GetComponent<StartScript>().code.Length; i++)
        {
            unlockCode += GameObject.FindGameObjectWithTag("Manager").GetComponent<StartScript>().code + " ";
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = nuetral;

        screen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!solved)
        {
            CheckInput();
        }
    }

    public override void Interact()
    {
        base.Interact();
        if(!solving)
        {
            screen.SetActive(true);
            solving = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = nuetral;
        }
    }

    void CheckInput()
    {
        if(unlockCode == input)
        {
            solved = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = correct;
            BackButton();
        }
        else if(numsInput == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = incorrect;
            BackButton();
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
        screen.SetActive(false);
        solving = false;
    }

    public void ButtonPress(int num)
    {
        if(numsInput == 3)
        {
            input += num;
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