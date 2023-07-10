using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Controller : MonoBehaviour
{
    public MinigameManager minigameManager;
    public ShootingController shootingController;
    public int enemyKilled = 0;
    public int friendKilled = 0;
    
    void Update()
    {
        if (enemyKilled >= 10)
        {
            minigameManager.NextMinigame(true);
        }
        if (friendKilled >= 2)
        {
            minigameManager.MinigameSoftFail(true);
        }
    }

    public void EnemyKilled(int Kill)
    {
        enemyKilled += Kill;
    }

    public void FriendKilled(int Wounded)
    {
        friendKilled += Wounded;
    }
}
