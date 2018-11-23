using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PennyseQuema : MonoBehaviour {
	GameMan manager;
	Animator pennyAnimator;

	// Use this for initialization
	void Start () {
		pennyAnimator = gameObject.GetComponent<Animator>();
		manager =  FindObjectOfType<GameMan>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D otro) {
		if(otro.gameObject.tag == "enemigo"){
			manager.DisminuirVida();
			pennyAnimator.SetBool("hurt", true);
			Invoke("TerminaDanio", 0.5f);
		}
	}


	public void TerminaDanio(){
		pennyAnimator.SetBool("hurt", false);
	}
}
