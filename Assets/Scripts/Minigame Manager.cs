using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class MinigameManager : MonoBehaviour
{
    public int Minigame = 0;
    public bool NextMini = false;
    public Animator transiton;
    public float transitionTime = 1f;
    public bool Restarting;
    public bool StopLooping;
    public Animator death;
    public float transitionDeathTimer = 1f;
    public int LivesLeft;

    // Start is called before the first frame update
    //private void Awake()
   // {
    //    if (_current != null && _current != this)
      //  {
        //    Destroy(this.gameObject);
        //}
       // else
     //   {
     //       _current = this;
     //       DontDestroyOnLoad(gameObject);
     //   }
   // }

    public void NextMinigame(bool nextGame)
    {
        if(nextGame == true)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transiton.SetTrigger("StartFade");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    //changed it reset for now because we dont want to punish people for not being able to complete a minigame with no tutorial
    public void MinigameSoftFail()
    {
        if(LivesLeft <= 0)
        {
            HardFail();
        }
        else
        {
            EventBus.Current.reducePrivateVar();
            Restarting = true;
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
        }
    }
    
    public void MainMenu(bool GoToMainMenu)
    {
        if(GoToMainMenu == true)
        {
            StartCoroutine(LoadLevel(0));
        }
    }
    public void CreditsStart(bool RunCredits)
    {
        if(RunCredits == true)
        {
            StartCoroutine(LoadLevel(13));
        }
    }

    public void Exit(bool quiting)
    {
        if (quiting == true)
        {
            Application.Quit();
        }
    }

     public void Update()
    {
        if(Restarting == true && StopLooping == true)
        {
            EventBus.Current.reducePrivateVar();
            StopLooping = false;
        }

        LivesLeft = EventBus.Current.ReturnLives();
    }

    public void HardFail()
    {
        StartCoroutine(LoadLevel(14));
    }

}
