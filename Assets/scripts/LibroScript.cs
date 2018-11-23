using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroScript : MonoBehaviour {
	public ApareceTexto texto;
	public string[] frase;
	public int fraseEsteLibro = 0;
	public GameObject panelFrase;
	public AudioClip[] audios;
	public AudioSource audioManager;
	public GameMan manejadorJuego;

	void Start(){
		manejadorJuego = Object.FindObjectOfType<GameMan>();
        Debug.Log("Hola Mundo");
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			texto.textToShow = frase[fraseEsteLibro];
			texto.audio = audios[fraseEsteLibro];
			panelFrase.SetActive(true);
			manejadorJuego.CambiarEstatusDeJuego(2);
			Invoke("DestroyBook", 15.0f);
		}
	}

	void DestroyBook(){
		panelFrase.SetActive(false);
		manejadorJuego.CambiarEstatusDeJuego(1);
		Destroy(gameObject);
	}
}
