using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public MinigameManager minigameManagerScript;
    public GameObject MinigameManager;

    private void Start()
    {
        if(minigameManagerScript == null)
        {
            MinigameManager = GameObject.Find("MinigameManager");
            MinigameManager.GetComponent<MinigameManager>();
            minigameManagerScript = MinigameManager.GetComponent<MinigameManager>();
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            collider.gameObject.GetComponent<Character>().start = false;
            minigameManagerScript.NextMinigame(true);
        }
        if (collider.gameObject.name == "Background")
        {
            collider.gameObject.GetComponent<BackgroundScroller>().start = false;
        }
    }
}
