using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultGame : InteractableItem
{
    // vault Image to turn
    public GameObject vaultKnob;
    // int for the vault number
    private int vaultNum;
    // float for the time between actions
    private float nextActionTime;
    // float for the time between landing on the correct number
    private float correctActionTime;
    // the vault code
    private int[] code;
    // when you finish one number of the sequence
    private int countDone;
    // bool for which way you are turning
    private bool turningRight;
    // canvas of the game
    public GameObject screen;
    // boolean for if in the game already
    private bool inGame;

    // Start is called before the first frame update
    new void Start()
    {
        vaultNum = 0;
        nextActionTime = 0.0f;
        correctActionTime = 0.0f;
        code = new int[3];
        countDone = 0;
        turningRight = false;
        inGame = false;

        code[0] = Random.Range(0, 360);
        code[1] = Random.Range(0, 360);
        code[2] = Random.Range(0, 360);

        screen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // User input for the game Q/E
        UserInput();

        // checking if the user is on the right space of knob
        CheckKnob();

        
        // check if they have won
        CheckWin();

        // check if need to change the controls
        CheckControl();
    }

    public override void Interact()
    {
        base.Interact();
        if (!inGame)
        {
            screen.SetActive(true);
            inGame = true;
        }
    }

    private void UserInput()
    {
        // user presses q go right
        if (Input.GetKey(KeyCode.Q))
        {
            nextActionTime += Time.deltaTime;
            if (nextActionTime >= .2f)
            {
                vaultNum++;
                if (vaultNum == 361) { vaultNum = 0; }
                vaultKnob.transform.Rotate(new Vector3(0, 0, 1));
                turningRight = true;
                nextActionTime %= .2f;
            }
        }
        // user presses e go left
        else if (Input.GetKey(KeyCode.E))
        {
            nextActionTime += Time.deltaTime;
            if (nextActionTime >= .2f)
            {
                vaultNum--;
                if (vaultNum == -1) { vaultNum = 360; }
                vaultKnob.transform.Rotate(new Vector3(0, 0, -1));
                turningRight = false;
                nextActionTime %= .2f;
            }
        }
    }

    // check to see if they are on the right space
    private void CheckKnob()
    {
        // if user is on the number wait a second if they are still on it while going in the right direction
        if (code[countDone] == vaultNum && ((turningRight && countDone % 2 == 0) || (!turningRight && countDone % 2 == 1)))
        {
            vaultKnob.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            correctActionTime += Time.deltaTime;
            if (correctActionTime >= 2f)
            {
                countDone++;
                vaultKnob.GetComponent<UnityEngine.UI.Image>().color = Color.white;
                correctActionTime %= 2f;
            }
        }
        else
        {
            vaultKnob.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }
    }

    // check if the user has won
    private void CheckWin()
    {
        // if countDone is 2 i.e. finished make the game stop and open the vault
        if (countDone == 3)
        {
            inGame = false;
            Destroy(gameObject);
        }
    }

    // checking if need to change control text
    private void CheckControl()
    {
        if(countDone%2 == 0)
        {
            screen.transform.GetChild(3).GetComponent<UnityEngine.UI.Text>().text = "Q";
        }
        else
        {
            screen.transform.GetChild(3).GetComponent<UnityEngine.UI.Text>().text = "E";
        }
    }

    // Exit button code
    public void ExitButton()
    {
        screen.SetActive(false);
        inGame = false;
    }
}
