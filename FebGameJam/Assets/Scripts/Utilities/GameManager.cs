using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // determines if the game was beaten or not
    private bool gameWon;

    //constructs the first instance of GameManager
    protected GameManager()
    {
        gameWon = false;
    }

    //ends the game
    public void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    //ends the game with a win
    public void WonGame()
    {
        gameWon = true;
        GameOver();
    }

    //starts the game
    public void StartGame()
    {
        gameWon = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }

    //brings you to the main menu
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    //returns if the game has been beaten or not
    public bool IsGameWon()
    {
        return gameWon;
    }
}
