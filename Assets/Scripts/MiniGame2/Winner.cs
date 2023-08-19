using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Winner : MonoBehaviour
{

    public AudioClip audioClip;
    public AudioSource audioSource;

    public Frequency frequencygreen;
    public SineWaveGenerator Sinewavered;
    
    public float redFrequency;
    public float redAmplitude;

    public float greenFrequency;
    public float greenAmplitude;


    public bool frequencyCorrect = false;
    public bool amplitudeCorrect = false;

    public float Timer = 0;

    public Slider slider;

    private MinigameManager minigameManagerScript;
    private GameObject MinigameManager;

    private void Start()
    {
        if (minigameManagerScript == null)
        {
            MinigameManager = GameObject.Find("MinigameManager");
            MinigameManager.GetComponent<MinigameManager>();
            minigameManagerScript = MinigameManager.GetComponent<MinigameManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(redFrequency + 0.01f > greenFrequency && redFrequency - 0.01f < greenFrequency)
        {
            frequencyCorrect = true;
        }
        else
        {
            frequencyCorrect = false;
        }

        if (redAmplitude + 0.01f > greenAmplitude && redAmplitude - 0.01f < greenAmplitude)
        {
            amplitudeCorrect = true;
        }
        else
        {
            amplitudeCorrect = false;
        }

        if(frequencyCorrect == true && amplitudeCorrect == true)
        {
            Timer = Timer + Time.deltaTime;
            slider.value = Timer;
            audioSource.clip = audioClip;
            audioSource.Play();
            if (Timer >= 3)
            {
                minigameManagerScript.NextMinigame(true);
            }
        }
        else
        {
            Timer = 0;
        }


        //random nymber that got generator

        //find the range from 0.5 min to 0.5 max



    }

    public void RedFrequency(float redfreq)
    {
        redFrequency = redfreq;
        //print(redFrequency);
    }

    public void RedAmplitude(float redamplitude)
    {
        redAmplitude = redamplitude;
        //print(redAmplitude);
    }

    public void GreenFrequency(float greenfreq)
    {
        greenFrequency = greenfreq;
        //print(greenFrequency);
    }

    public void GreenAmplitude(float greenamplitude)
    {
        greenAmplitude = greenamplitude;
        //print(greenAmplitude);
    }
}







