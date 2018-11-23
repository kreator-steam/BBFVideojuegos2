using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PennySeCae : MonoBehaviour {
	GameMan manager;

	// Use this for initialization
	void Start () {
		manager =  FindObjectOfType<GameMan>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerExit2D(Collider2D other) {
		if(other.gameObject.tag == "bg"){
			manager.DisminuirVida();
			gameObject.transform.position = new Vector2(0,0.5f);
		}
	}
}
