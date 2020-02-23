using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    private GameManager manager;
    public GameObject won;
    public GameObject lost;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameManager.Instance;
        if(manager.IsGameWon())
        {
            won.SetActive(true);
        }
        else
        {
            lost.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
