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

    public Animator CharaterAnim;
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
        if(IsDashing == true)
        {
            CharaterAnim.SetBool("Dashing", true);
        }
        else
        {
            CharaterAnim.SetBool("Dashing", false);
        }
        if (IsSliding == true)
        {
            CharaterAnim.SetBool("Sliding", true);
        }
        else
        {
            CharaterAnim.SetBool("Sliding", false);
        }
        if (IsHiding == true)
        {
            CharaterAnim.SetBool("Hiding", true);
        }
        else
        {
            CharaterAnim.SetBool("Hiding", false);
        }
        if (IsJumping == true)
        {
            CharaterAnim.SetBool("Jumping", true);
        }
        else
        {
            CharaterAnim.SetBool("Jumping", false);
        }
        if (InDashCheck == true)
        {
            if(IsDashing == true)
            {
                Debug.Log("DASHING");
            }
            else
            {
                gameObject.GetComponent<Character>().start = false;
                minigameManagerScript.MinigameSoftFail(true);
            }
        }
        if(InSlideCheck == true)
        {
            if (IsSliding == true)
            {
                Debug.Log("SLIDING");
            }
            else
            {
                gameObject.GetComponent<Character>().start = false;
                minigameManagerScript.MinigameSoftFail(true);
            }
        }
        if(InHideCheck == true)
        {
            if (IsHiding == true)
            {
                Debug.Log("HIDING");
            }
            else
            {
                gameObject.GetComponent<Character>().start = false;
                minigameManagerScript.MinigameSoftFail(true);
            }
        }
        if(InJumpCheck == true)
        {
            if(IsJumping == true)
            {
                Debug.Log("JUMPING");
            }
            else
            {
                gameObject.GetComponent<Character>().start = false;
                minigameManagerScript.MinigameSoftFail(true);
            }
        }
    }
}
