using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // determines if the game was beaten or not
    private bool GameWon
    {
        set
        {
            GameWon = value;
        }
        get
        {
            return GameWon;
        }
    }

    //constructs the first instance of GameManager
    protected GameManager()
    {
        GameWon = false;
    }

    //ends the game
    public void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    //starts the game
    public void StartGame()
    {
        GameWon = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }
}
