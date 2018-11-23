﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApareceTexto : MonoBehaviour {
	 [SerializeField] private Text textToUse;
    [SerializeField] private bool useThisText = false;
    [TextAreaAttribute(4, 15)]
    [SerializeField] public string textToShow;
    [SerializeField] private bool useTextText = false;
    [SerializeField] private float fadeSpeedMultiplier = 0.25f;
    [SerializeField] private bool fade;
    private float colorFloat = 0.1f;
    private int colorInt;
    private int letterCounter = 0;
    private string shownText;
	public AudioSource audioManager;
	public AudioClip audio;

    private void Start()
    {
        if (useThisText)
        {
            textToUse = GetComponent<Text>();
        }
        if (useTextText)
        {
            textToShow = textToUse.text;
        }
        if (fade)
        {
            Fade();
        }
    }
    private IEnumerator FadeInText()
    {
        while (letterCounter < textToShow.Length)
        {
            if (colorFloat < 1.0f)
            {
                colorFloat += Time.deltaTime * fadeSpeedMultiplier;
                colorInt = (int)(Mathf.Lerp(0.0f, 1.0f, colorFloat) * 255.0f);
                textToUse.text = shownText + "<color=\"#FFFFFF" + string.Format("{0:X}", colorInt) + "\">" + textToShow[letterCounter] + "</color>";
            }
            else
            {
                colorFloat = 0.1f;
                shownText += textToShow[letterCounter];
                letterCounter++;
            }
            yield return null;
        }
    }
    public void Fade()
    {
    	audioManager.clip = audio;
    	audioManager.Play();
        StartCoroutine(FadeInText());
    }
}
