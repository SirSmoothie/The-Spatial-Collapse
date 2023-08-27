using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager2 : MonoBehaviour
{
    public AudioSource One;
    public AudioSource Two;
    public AudioClip Gunshot;
    public AudioClip Death;
    public AudioClip Correct;
    public AudioClip Incorrect;
    
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

        }
    }
    
    public void Gun()
    {
        One.Stop();
        One.clip = Gunshot;
        One.Play();
    }
    public void Dead()
    {
        Two.Stop();
        Two.clip = Death;
        Two.Play();
    }
    public void Yes()
    {
        One.Stop();
        One.clip = Correct;
        One.Play();
    }
    public void No()
    {
        One.Stop();
        One.clip = Incorrect;
        One.Play();
    }
}
