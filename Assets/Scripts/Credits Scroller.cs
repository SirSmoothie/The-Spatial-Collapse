using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScroller : MonoBehaviour
{
    public float Startingpos = -700f;
    public float Endpos = 7000f;
    public float Speed = 100f;
    public float CurrentSpeed = 0f;
    public GameObject Credits;
    public MinigameManager minigameManager;
    public float SpeedMultiply = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Credits.transform.position = new Vector3(Credits.transform.position.x, Startingpos, Credits.transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Credits.transform.position = new Vector3(Credits.transform.position.x, Credits.transform.position.y + CurrentSpeed, Credits.transform.position.z);

        if(Credits.transform.position.y >= Endpos)
        {
            minigameManager.MainMenu(true);
        }
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("GO FASTER");
            CurrentSpeed = Speed * SpeedMultiply;
        }
        else
        {
            CurrentSpeed = Speed;
        }
    }
}
