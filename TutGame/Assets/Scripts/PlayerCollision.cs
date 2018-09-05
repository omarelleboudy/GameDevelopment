using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement Movement;


    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
	
}
