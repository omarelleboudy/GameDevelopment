using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform Player;
    public Vector3 offset;
    public float x = 0;

	// Update is called once per frame
	void Update ()
    {
        transform.position = Player.position + offset;

    }
    void LetUpdate()
    {
        if (Mathf.Abs(x)>0.5f)
        {
            if (x>0)
            {
                x -= Time.deltaTime;
            }
            if (x < 0)
            {
                x += Time.deltaTime;
            }
        }

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, x));


    }

}
