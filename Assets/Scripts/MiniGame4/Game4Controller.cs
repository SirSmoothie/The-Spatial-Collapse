using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Controller : MonoBehaviour
{
    public ShootingController shootingController;
    public int enemyKilled = 0;
    public int friendKilled = 0;

    public MinigameManager minigameManagerScript;
    public GameObject MinigameManager;

    private void Start()
    {
        if (minigameManagerScript == null)
        {
            MinigameManager = GameObject.Find("MinigameManager");
            MinigameManager.GetComponent<MinigameManager>();
            minigameManagerScript = MinigameManager.GetComponent<MinigameManager>();
        }
    }
    void Update()
    {
        if (enemyKilled >= 10)
        {
            minigameManagerScript.NextMinigame(true);
        }
        if (friendKilled >= 2)
        {
            minigameManagerScript.MinigameSoftFail();
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
