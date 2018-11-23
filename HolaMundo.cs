using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour {
    int frame = 0;
	// Use this for initialization
	void Start () {
        Debug.Log("Hola Mundo");
    }
	
	// Update is called once per frame
	void Update () {
        frame++;
       // Debug.Log("Hola frame: " + frame);
    }
}
