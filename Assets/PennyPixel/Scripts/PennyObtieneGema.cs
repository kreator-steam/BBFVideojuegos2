using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PennyObtieneGema : MonoBehaviour {
	GameMan manager;

	// Use this for initialization
	void Start () {
		manager = FindObjectOfType<GameMan>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Gem");
		manager.AumentarScore();
	}
}
