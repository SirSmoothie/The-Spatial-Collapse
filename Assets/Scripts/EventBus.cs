using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventBus : MonoBehaviour
{

    
    //^sets and event named youGotMail
    private static EventBus _current;
    public static EventBus Current { get { return _current; } }
    private int privateLives = 3;
    public MinigameManager Minigame;

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        } 
    }

    public int ReturnLives() {
        return privateLives;
    }

    public void reducePrivateVar(){
        privateLives--;
    }

    public event Action youGotMail;
    public void youGotMailTrigger(){
        youGotMail();
    }

    public event Action lightsGoOff;
    public void lightsGoOffTrigger(){
        lightsGoOff();
    }

    public event Action lightsGoOn;
    public void lightsGoOnTrigger(){
        lightsGoOn();
    }

    public void ResetLives()
    {
        privateLives = 3;
    }
    
}
