using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MinigameManager : MonoBehaviour
{
    public int Minigame = 0;
    public bool NextMini = false;

    public Animator transiton;

    public float transitionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NextMini == true)
        {
            NextMinigame(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

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

    public void MinigameFail(bool gameFail)
    {
        if(gameFail == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    //changed it reset for now because we dont want to punish people for not being able to complete a minigame with no tutorial
    public void MinigameSoftFail(bool gameSoftFail)
    {
        if (gameSoftFail == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }

    }
    
    public void MainMenu(bool GoToMainMenu)
    {
        if(GoToMainMenu == true)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void CreditsStart(bool RunCredits)
    {
        if(RunCredits == true)
        {
            SceneManager.LoadScene("Credits");
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
