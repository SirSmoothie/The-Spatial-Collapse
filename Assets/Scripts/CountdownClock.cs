using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountdownClock : MonoBehaviour
{
    public float timeremaining = 30f;
    public TMP_Text CountDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeremaining >= 0.01)
        {
            timeremaining = timeremaining - Time.deltaTime;
            Debug.Log(timeremaining);
            int Seconds = Mathf.FloorToInt(timeremaining % 60);
            CountDown.text = string.Format("{00}", Seconds);
        }
        else
        {
            print("you fail");
        }
    }
}
