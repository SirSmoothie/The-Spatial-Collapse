using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public MinigameManager minigameManager;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            collider.gameObject.GetComponent<Character>().start = false;
            minigameManager.NextMinigame(true);
        }
    }
}
