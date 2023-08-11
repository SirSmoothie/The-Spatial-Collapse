using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_Skip : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextSceneInBuildSettings();
            Debug.Log("yes");
        }
    }

    
    public void LoadNextSceneInBuildSettings()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1);

        SceneManager.LoadScene(nextSceneIndex);
    }

}
