using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTimer : MonoBehaviour

{
    public AudioSource audioSource; // Reference to the AudioSource component
    public float countdownDuration = 10f; // Total countdown duration in seconds
    public AudioClip audioClip; // Audio clip to play

    private bool hasPlayedAudio = false;
    private float timeRemaining;

    private void Start()
    {
        // Initialize the countdown timer
        timeRemaining = countdownDuration;
    }

    private void Update()
    {
        // Update the countdown timer
        timeRemaining -= Time.deltaTime;

        // Check if 1 second is remaining and the audio hasn't been played yet
        if (timeRemaining <= 1f && !hasPlayedAudio)
        {
            // Play the audio clip
            audioSource.clip = audioClip;
            audioSource.Play();

            hasPlayedAudio = true; // Set the flag to indicate audio has been played
        }
    }
}

