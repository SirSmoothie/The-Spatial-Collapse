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
    private static MinigameManager _current;
    public static MinigameManager Current { get { return _current; } }
    private int privateLives = 3;

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
    public void MinigameSoftFail(bool gameSoftFail)
    {
        if (gameSoftFail == true)
        {
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
}
