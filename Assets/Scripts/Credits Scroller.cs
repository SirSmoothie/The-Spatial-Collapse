using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScroller : MonoBehaviour
{
    public float Startingpos = -700f;
    public float Endpos = 7000f;
    public float Speed = 100f;
    public GameObject Credits;
    public MinigameManager minigameManager;
    // Start is called before the first frame update
    void Start()
    {
        Credits.transform.position = new Vector3(Credits.transform.position.x, Startingpos, Credits.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Credits.transform.position = new Vector3(Credits.transform.position.x, Credits.transform.position.y + Speed, Credits.transform.position.z);

        if(Credits.transform.position.y >= Endpos)
        {
            minigameManager.MinigameFail(true);
        }
    }
}
