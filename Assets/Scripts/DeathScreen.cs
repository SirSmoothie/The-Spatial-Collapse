using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public float timer;
    public float forcedtime = 5;
    public MinigameManager Minigame;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= forcedtime)
        {
            ReturnToMainMenu();
        }
    }

    void ReturnToMainMenu()
    {
        EventBus.Current.ResetLives();
        Minigame.MainMenu(true);
    }
}
