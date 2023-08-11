using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerG5 : MonoBehaviour

{



    public int Wiresconnected = 0;
    public int WiresUnconnected = 0;

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
    // Update is called once per frame
    void Update()
    {
        if(Wiresconnected >= 6)
        {
            minigameManagerScript.NextMinigame(true);
        }
    }

    public void ConnectedAWire(int wireconnected)
    {
        Wiresconnected += wireconnected;
    }

    

}
