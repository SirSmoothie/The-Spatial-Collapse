using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip soundClip;
    public AudioSource audioSource;

    public bool isPlaying = false;
    public float playStartTime;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = soundClip;
    }

    public void Update()
    {
        if (isPlaying)
        {
            if (Time.time - playStartTime >= 10f)
            {
                StopSound();
            }
        }
    }

    public void PlaySound()
    {
        if (!isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
            playStartTime = Time.time;
        }
    }

    public void StopSound()
    {
        if (isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }
}

