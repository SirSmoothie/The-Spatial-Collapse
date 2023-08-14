using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    public MinigameManager minigameManager;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            minigameManager.NextMinigame(true);
        }

    }

    private void LoadSceneInBuildSettings()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1);

        SceneManager.LoadScene(nextSceneIndex);
            
        
    }
    // Note from Rory I dont understand why you had this 'LoacSceneInBuildSettings', changing the Tutorial skip to activate the next minigame in the minigame manager so the 
    // fade to black, fades to black and vice versa.

}
