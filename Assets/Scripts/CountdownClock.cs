using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountdownClock : MonoBehaviour
{
    public float timeremaining = 30f;
    public TMP_Text CountDown;
    public MinigameManager minigameManager;
    public GameObject SliderRed;
    public Slider slider;



    void Update()
    {
        if(timeremaining >= 0.01)
        {
            timeremaining = timeremaining - Time.deltaTime;
            Debug.Log(timeremaining);
            int Seconds = Mathf.FloorToInt(timeremaining % 60);
            //CountDown.text = string.Format("{00}", Seconds);
            slider.value = timeremaining;

  
            

        }
        else
        {
            print("you fail");
            TimerFail();
        }


    }

    public void TimerFail()
    {
        minigameManager.MinigameFail(true);
    }
}
