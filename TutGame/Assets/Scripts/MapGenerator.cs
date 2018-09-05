using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject objectGenerator;
    private Vector3 lastPlace;
	// Use this for initialization
	void Start ()
    {
        lastPlace = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
    }
}
