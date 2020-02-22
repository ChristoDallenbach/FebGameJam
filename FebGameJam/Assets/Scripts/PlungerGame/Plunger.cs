using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    private Transform visuals;
    private Transform rewards;
    private Transform plunger;
    private UnityEngine.UI.Text text;
    private bool goodReward;
    private bool canBePlayed;
    private bool gameDone;
    private bool plungerDown;
    private int numOfPlunges;
    const int maxPlunges = 10;
    private Transform reward;
    private Vector3 rewardFinalPos;

    // Start is called before the first frame update
    void Start()
    {
        canBePlayed = false;
        gameDone = false;
        plungerDown = false;

        visuals = transform.GetChild(2);
        rewards = transform.GetChild(1);
        plunger = visuals.GetChild(1);
        text = visuals.GetChild(0).GetComponent<UnityEngine.UI.Text>();

        numOfPlunges = 0;
        text.text = "";

        gameObject.SetActive(false);
        //HasPlunger();
    }

    // Update is called once per frame
    void Update()
    {
        if(!canBePlayed)
        {
            return;
        }

        if(gameDone)
        {
            reward.position = Vector3.Lerp(reward.position, rewardFinalPos, 0.05f);
            return;
        }

        
        if(plungerDown && Input.GetKeyDown(KeyCode.Q))
        {
            plunger.position = new Vector3(plunger.position.x, plunger.position.y + 100);
            plungerDown = false;
            text.text = "E";
        }
        else if(!plungerDown && Input.GetKeyDown(KeyCode.E))
        {
            plunger.position = new Vector3(plunger.position.x, plunger.position.y - 100);
            plungerDown = true;
            numOfPlunges++;
            text.text = "Q";
        }

        if(numOfPlunges >= maxPlunges)
        {
            FindReward();
            gameDone = true;
            plunger.position = new Vector3(plunger.position.x, plunger.position.y + 300);
            text.text = "";
        }
    }

    public void HasPlunger()
    {
        canBePlayed = true;
            text.text = "E";
            plunger.gameObject.SetActive(true);
    }

    public void FindReward()
    {
        if(goodReward)
        {
            reward = rewards.GetChild(0);
        }
        else
        {
            reward = rewards.GetChild(1);
        }

        rewardFinalPos = new Vector3(reward.position.x, reward.position.y + 200);
    }

    public void HasGoodReward()
    {
        goodReward = true;
    }

    public bool IsBeat()
    {
        return gameDone;
    }
}
