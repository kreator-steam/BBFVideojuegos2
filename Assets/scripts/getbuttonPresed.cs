
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getbuttonPresed : MonoBehaviour {
	public Text teclatxt;
	AudioSource thisAs;
	public KeyCode[] trampa;
	int indice = 0;
	private void OnGUI() {
		 Event evento = Event.current;
        if (evento.isKey)
        {
           // Debug.Log("detectada" + evento.keyCode);
			teclatxt.text = "Tecla: "+evento.keyCode;

        }
	}
	private void Start() {
		Debug.Log(KeyCode.D);
		trampa = new KeyCode[]
                              {
                                KeyCode.UpArrow,
                                KeyCode.UpArrow,
                                KeyCode.DownArrow,
                                KeyCode.DownArrow,
                                KeyCode.LeftArrow,
                                KeyCode.RightArrow,
                                KeyCode.LeftArrow,
                                KeyCode.RightArrow,
                                KeyCode.B,
                                KeyCode.A,
								KeyCode.Return
								};
								thisAs = gameObject.GetComponent<AudioSource>();
	}
	private void Update() {
		if(Input.anyKeyDown){
			if(Input.GetKeyDown(trampa[indice])){
				indice++;
				Debug.Log(indice);
			}
			else{
				indice =0;
			}
		}
		if(indice == trampa.Length){
			if(!thisAs.isPlaying)
			thisAs.Play();
			indice = 0;

		}
	}	
}
