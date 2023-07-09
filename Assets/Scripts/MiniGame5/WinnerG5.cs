using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerG5 : MonoBehaviour

{



    public int Wiresconnected = 0;
    public MinigameManager minigame;
    public int WiresUnconnected = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Wiresconnected >= 6)
        {
            minigame.NextMinigame(true);
        }
    }

    public void ConnectedAWire(int wireconnected)
    {
        Wiresconnected += wireconnected;
    }

    

}
