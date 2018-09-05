using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject CompleteLevelUI;

    public void WonGame()
    {

        CompleteLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over");
            // Restarting the game
            Invoke("Restart", restartDelay);


        }
    }




    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
