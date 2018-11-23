using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour {
	public int tiempoDelNivel= 120;
	int score = 0;
	public float tiempoTranscurrido;
	public GameObject gameoverPanelGO;
	public Text txtTiempoRestante;
	public Text txtScore;
	public Image[] saludImg;
	int salud = 3;
	bool jugando = false;
	bool terminado = false;
	public GameObject gameOverPanel;
	public PlayerPlatformerController playerController;
	public int estatusDeJuego; //// 1 = jugando, 2 = en evento, 3 = gameover, 4 = exito
	public AudioSource audioFondo;
	// Use this for initialization
	void Start () {
		estatusDeJuego = 1;

	}
	
	// Update is called once per frame
	void Update () {
		if(estatusDeJuego == 1){
		tiempoTranscurrido += Time.deltaTime;
		int segundos = (int)tiempoTranscurrido % 60; 
		txtTiempoRestante.text = "Tiempo: " + (tiempoDelNivel - segundos);
	}

	}
	/////////////////////////////Estados de Juego
	public void CambiarEstatusDeJuego(int status){
		estatusDeJuego = status;
		switch (status){
			case 1:
				playerController.movible = true;
				audioFondo.volume = 0.6f;
			break;
			case 2:
				playerController.movible = false;
				audioFondo.volume = 0.2f;
			break;
		}
	}


	///////////////// Funciones Penny

	public void DisminuirVida(){
		salud -=1;
		switch(salud){
			case(2):
			saludImg[salud].color = new Color(1,1,1,0.4f);
			break;
			case(1):
			saludImg[salud].color = new Color(1,1,1,0.4f);
			break;
			case(0):
			saludImg[salud].color = new Color(1,1,1,0.4f);
			break;
			default:
			//saludImg[salud].color = new Color(1,1,1,0.4f);
			//TODO Gameover
			GameOver();
			break;
		}
	}
	public void AumentarScore(){
		score +=1;
		txtScore.text = "Score: " + score.ToString().PadLeft(5,'0');
	}






	//////////////////Opciones de Juego

	public void GameOver(){
		gameOverPanel.SetActive(true);
	}
	public void repeat(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	public void exit(){
		Application.Quit();
	}
}
