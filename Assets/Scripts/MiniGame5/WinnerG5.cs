using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnerG5 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip wireConnectedSound;
    public int Wiresconnected = 0;
    public int WiresUnconnected = 0;
    public MinigameManager minigameManagerScript;
    public GameObject MinigameManager;
    public TextMeshProUGUI bombText;
    private float countdownTimer = 0.00f; 

    private void Start()
    {
        if (minigameManagerScript == null)
        {
            MinigameManager = GameObject.Find("MinigameManager");
            minigameManagerScript = MinigameManager.GetComponent<MinigameManager>();
        }
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (countdownTimer > 0)
        {
            UpdateTimerDisplay();
        }

        if (Wiresconnected >= 6)
        {
            minigameManagerScript.NextMinigame(true);
        }
    }

    public void ConnectedAWire(int wireconnected)
    {
        Wiresconnected += wireconnected;
        countdownTimer += 10.0f; // Add 10 seconds to the timer
        countdownTimer = Mathf.Min(countdownTimer, 60.0f); // Cap the timer at 60 seconds
        // Play the wire connected sound
        if (audioSource != null && wireConnectedSound != null)
        {
            audioSource.clip = wireConnectedSound;
            audioSource.Play();
        }
    }

    // Update the timer display text
    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(countdownTimer / 60);
        int seconds = Mathf.FloorToInt(countdownTimer % 60);
        string timeText = string.Format("{0:0}:{1:00}", minutes, seconds);
        bombText.text = timeText;
    }
}

