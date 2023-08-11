using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Confirmationbutton : MonoBehaviour
{
    public bool TestingAligned = false;
    public bool Solved = false;
    public Renderer renderer;
    public float Timer;
    public bool SetTimer2;
    public float Timer2;
    public bool greenTimer;
    public bool tested;
    public bool pressed;
    // Start is called before the first frame update

    public MinigameManager minigameManagerScript;
    public GameObject MinigameManager;

    private void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        if (minigameManagerScript == null)
        {
            MinigameManager = GameObject.Find("MinigameManager");
            MinigameManager.GetComponent<MinigameManager>();
            minigameManagerScript = MinigameManager.GetComponent<MinigameManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") == true)
        {
            pressed = true;
        }
        if (Input.GetKeyUp("space") == true)
        {
            Timer = 0;
            pressed = false;
        }
        if (pressed == true)
        {
            Timer = Timer + Time.deltaTime;
        }
        if(Timer >= 3 && pressed == true)
        {
            TestingAligned = true;
            Timer = 0;
            pressed = false;
        }
        if(TestingAligned == true)
        {
            Debug.Log("testing time");
            if (Solved == true)
            {
                TestingAligned = false;
                renderer.material.color = Color.green;
                greenTimer = true;
            }
            else
            {
                TestingAligned = false;
                renderer.material.color = Color.red;
                SetTimer2 = true;
            }
        }
        if(greenTimer == true)
        {
            Timer2 = Timer2 + Time.deltaTime;
            if (Timer2 >= 1)
            {
                minigameManagerScript.NextMinigame(true);
            }
        }
        if (SetTimer2 == true)
        {
            if (Timer2 <= 1)
            {
                Timer2 = Timer2 + Time.deltaTime;
            }
            if (Timer2 >= 1)
            {
                renderer.material.color = Color.white;
                Timer2 = 0;
                SetTimer2 = false;
            }
        }
        if (pressed == true && TestingAligned == false)
        {
            renderer.material.color = Color.yellow;
        }
        else if(pressed == false && renderer.material.color == Color.yellow)
        {
            renderer.material.color = Color.white;
        }
        
    }

    public void Aligned(bool aligned)
    {
        if (aligned == true)
        {
            Solved = true;
            aligned = false;
        }
    }
}
