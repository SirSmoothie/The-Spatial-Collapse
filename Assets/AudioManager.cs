using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // public AudioSource audioSource;
    // public AudioClip Running;
    // public AudioClip Jumping;
    // public AudioClip Sliding;
    // public AudioClip Hiding;
    //  public AudioClip Dashing;
    // public AudioClip LaserTurret;

    // public bool PlayingAudio;

    public AudioSource audioSource;
    public AudioSource audioSourceOnce;
    public AudioSource audioSourceOnce2;
    public AudioClip RunningClip;
    public AudioClip JumpingClip;
    public AudioClip SlidingClip;
    public AudioClip HidingClip;
    public AudioClip DashingClip;
    public AudioClip VoiceLineGood1Clip;
    public AudioClip VoiceLineGood2Clip;
    public AudioClip VoiceLineGood3Clip;
    public AudioClip VoiceLineBadClip;
    public AudioClip LaserTurretClip;

    public int VoiceLineNo;
    public void Running()
    {
        audioSourceOnce.Stop();
        audioSource.clip = RunningClip;
        audioSource.Play();
    }
    public void Jumping()
    {
        audioSource.Stop();
        audioSourceOnce.clip = JumpingClip;
        audioSourceOnce.Play();
    }
    public void Sliding()
    {
        audioSource.Stop();
        audioSourceOnce.clip = SlidingClip;
        audioSourceOnce.Play();
    }
    public void Hiding()
    {
        audioSource.Stop();
        audioSourceOnce.clip = HidingClip;
        audioSourceOnce.Play();
    }
    public void Dashing()
    {
        audioSource.Stop();
        audioSourceOnce.clip = DashingClip;
        audioSourceOnce.Play();
    }

    public void LaserTurret()
    {
        audioSourceOnce2.Stop();
        audioSourceOnce2.clip = LaserTurretClip;
        audioSourceOnce2.Play();
    }
    public void VoiceLineBad()
    {
        audioSourceOnce2.Stop();
        audioSourceOnce2.clip = VoiceLineBadClip;
        audioSourceOnce2.Play();
    }
    public void VoiceLineGood()
    {
        VoiceLineNo = Random.Range(0,2);
        if(VoiceLineNo == 0) 
        {
            audioSourceOnce2.Stop();
            audioSourceOnce2.clip = VoiceLineGood1Clip;
            audioSourceOnce2.Play();
        }
        else if (VoiceLineNo == 1)
        {
            audioSourceOnce2.Stop();
            audioSourceOnce2.clip = VoiceLineGood2Clip;
            audioSourceOnce2.Play();
        }
        else if (VoiceLineNo == 2)
        {
            audioSourceOnce2.Stop();
            audioSourceOnce2.clip = VoiceLineGood3Clip;
            audioSourceOnce2.Play();
        }

    }
    public void StopAudioClips()
    {
        audioSource.Stop();
        audioSourceOnce.Stop();
        audioSourceOnce2.Stop();
    }
}
