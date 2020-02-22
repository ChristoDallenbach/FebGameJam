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
    new void Start()
    {
        canBePlayed = false;
        gameDone = false;
        plungerDown = true;
        visuals = transform.GetChild(1);
        rewards = transform.GetChild(0);
        visuals.GetChild(1).position = new Vector3(1.3f, 1.75f, 1);
        visuals.GetComponentInChildren<UnityEngine.UI.Text>().text = "";
        numOfPlunges = 0;
        HasPlunger();
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
                visuals.GetChild(1).position = new Vector3(1.3f, 0.32f, 1);
                visuals.GetComponentInChildren<UnityEngine.UI.Text>().text = "E";
                plungerDown = false;
            }
            else if (Input.GetKeyDown(KeyCode.E) && !plungerDown)
            {
                visuals.GetChild(1).position = new Vector3(1.3f, -1.5f, 1);
                plungerDown = true;
                visuals.GetComponentInChildren<UnityEngine.UI.Text>().text = "Q";
                numOfPlunges++;
            }
        } 
        else
        {
            reward.position = Vector3.Lerp(reward.position, new Vector3(1.0f, -0.45f, 1), 0.1f);
        }

        if(numOfPlunges >= maxPlunges)
        {
            gameDone = true;
            visuals.GetComponentInChildren<UnityEngine.UI.Text>().text = "";
            visuals.GetChild(1).position = new Vector3(1.3f, 3.85f, 1);
            FindReward();
        }
    }

    public void HasPlunger()
    {
        canBePlayed = true;
        visuals.GetComponentInChildren<UnityEngine.UI.Text>().text = "Q";
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
