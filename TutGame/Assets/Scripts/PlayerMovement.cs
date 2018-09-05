using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    // This defines the amount of force in the Z axis for the player to move
    // Defining it as public for it to show up in the inspector
    public float ZForce = 1000f;
    // Amount of force in the X axis
    public float XForce = 500f;
    // Amount of force in the Y axis
    //public float YForce = 100f;

    // We marked this as -Fixed-Update because we are using it to mess with physics
    void FixedUpdate()
    {
        // Add force to the +ve Z axis
        rb.AddForce(0, 0, ZForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(XForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Camera.main.GetComponent<CameraFollow>().x = 90f; 
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-XForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Camera.main.GetComponent<CameraFollow>().x = -90f;
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
       
    }
}
