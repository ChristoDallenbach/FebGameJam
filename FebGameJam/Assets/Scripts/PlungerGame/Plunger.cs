using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    private Transform visuals;
    private Transform rewards;
    private bool goodReward;
    private bool canBePlayed;
    private bool gameDone;
    private bool plungerDown;
    private int numOfPlunges;
    const int maxPlunges = 50;
    private Transform reward;

    // Start is called before the first frame update
    void Start()
    {
        canBePlayed = false;
        gameDone = false;
        plungerDown = true;
        visuals = transform.GetChild(1);
        rewards = transform.GetChild(0);
        visuals.GetChild(1).GetComponent<RectTransform>().position = new Vector3(775, 500, 0);
        numOfPlunges = 0;
        //HasPlunger();
    }

    // Update is called once per frame
    void Update()
    {
        if(!canBePlayed)
        {
            return;
        }

        if(!gameDone)
        {
            if(Input.GetKeyDown(KeyCode.Q) && plungerDown)
            {
                visuals.GetChild(1).GetComponent<RectTransform>().position = new Vector3(775, 300, 0);
                visuals.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "E";
                plungerDown = false;
            }
            else if (Input.GetKeyDown(KeyCode.E) && !plungerDown)
            {
                visuals.GetChild(1).GetComponent<RectTransform>().position = new Vector3(775, 200, 0);
                plungerDown = true;
                visuals.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "Q";
                numOfPlunges++;
            }
        } 
        else
        {
            reward.position = Vector3.Lerp(reward.position, new Vector3(1.0f, -0.45f), 0.1f);
        }

        if(numOfPlunges >= maxPlunges)
        {
            gameDone = true;
            visuals.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "";
            visuals.GetChild(1).GetComponent<RectTransform>().position = new Vector3(775, 800, 0);
            FindReward();
        }
    }

    public void HasPlunger()
    {
        canBePlayed = true;
        visuals.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "Q";
        visuals.GetChild(1).gameObject.SetActive(true);
    }

    public void FindReward()
    {
        if(goodReward)
        {
            reward = rewards.GetChild(0);
        } else
        {
            reward = rewards.GetChild(1);
        }
    }
}
