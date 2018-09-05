using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;


    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Player")
        {

            FindObjectOfType<GameManager>().WonGame();
            Invoke("Restart", 4f);

        }
    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}