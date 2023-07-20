using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSkills : MonoBehaviour
{
    public bool InDashCheck = false;
    public bool InSlideCheck = false;
    public bool InHideCheck = false;
    public bool InJumpCheck = false;

    public bool IsDashing = false;
    public bool IsSliding = false;
    public bool IsHiding = false;
    public bool IsJumping = false;

    public MinigameManager minigamemanager;
    // Start is called before the first frame update
    void Start()
    {
        minigamemanager = GetComponent<MinigameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(InDashCheck == true)
        {
            if(IsDashing == true)
            {
                Debug.Log("DASHING!!!!!!!");
            }
            else
            {
                minigamemanager.MinigameFail(true);
            }
        }
        if(InSlideCheck == true)
        {
            if (IsSliding == true)
            {
                Debug.Log("DASHING1111111");
            }
            else
            {
                minigamemanager.MinigameFail(true);
            }
        }
        if(InHideCheck == true)
        {
            if (IsHiding == true)
            {
                Debug.Log("DASHING222222222222");
            }
            else
            {
                minigamemanager.MinigameFail(true);
            }
        }
        if(InJumpCheck == true)
        {
            if(IsJumping == true)
            {
                Debug.Log("DASHING3333333333");
            }
            else
            {
                minigamemanager.MinigameFail(true);
            }
        }
    }
}
