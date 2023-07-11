using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MinigameManager : MonoBehaviour
{
    public int Minigame = 0;
    public bool NextMini = false;
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
            Debug.Log("does dis work?");
        }
    }

    public void NextMinigame(bool nextGame)
    {
        if(nextGame == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("does dis scene work?");
        }
    }

    public void MinigameFail(bool gameFail)
    {
        if(gameFail == true)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void MinigameSoftFail(bool gameSoftFail)
    {
        if (gameSoftFail == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            
        }

    }

}
