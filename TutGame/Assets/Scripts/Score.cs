using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text ScoreText;
    private float x;
    private float y;
	// Update is called once per frame
	void Update ()
    {
        x = player.position.z;
        y = x / 20;
        ScoreText.text = y.ToString("0");
	}
}
