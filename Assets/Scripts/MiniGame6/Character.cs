using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float x = 1f;
    public float speed = 1f;
    public float AccelerationFactor = 1f;

    public bool start = true;
    public bool DidWeTellTheRunningAudioToStart = false;

    public Rigidbody rigidbody;
    public CharacterSkills characterSkills;
    public GameObject Text;
    public GameObject BackGround;
    public AudioManager audioManager;

    public float AbilityCoolDown = 1f;
    public float AbilityCoolDownTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        characterSkills = GetComponent<CharacterSkills>();
    }

    void Jumping(bool jump)
    {
        characterSkills.IsJumping = jump;
    }
    void Hiding(bool hide)
    {
        characterSkills.IsHiding = hide;
    }
    void Sliding(bool slide)
    {
        characterSkills.IsSliding = slide;
    }
    void Dashing(bool dash)
    {
        characterSkills.IsDashing = dash;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
            audioManager.Jumping();
            DidWeTellTheRunningAudioToStart = false;
            Jumping(true);
        }
        if (Input.GetKeyDown("a") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
            audioManager.Hiding();
            DidWeTellTheRunningAudioToStart = false;
            Hiding(true);
        }
        if (Input.GetKeyDown("s") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
            audioManager.Sliding();
            DidWeTellTheRunningAudioToStart = false;
            Sliding(true);
        }
        if (Input.GetKeyDown("d") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
            audioManager.Dashing();
            DidWeTellTheRunningAudioToStart = false;
            Dashing(true);
        }

        AbilityCoolDownTimer -= Time.deltaTime;
        if (AbilityCoolDownTimer <= 0) 
        {
            Dashing(false);
            Jumping(false);
            Hiding(false);
            Sliding(false);
        }

        if(AbilityCoolDownTimer <= 0 && DidWeTellTheRunningAudioToStart == false)
        {
            audioManager.Running();
            DidWeTellTheRunningAudioToStart = true;
        }
    }

    private void FixedUpdate()
    {
        if (start == true)
        {
            rigidbody.velocity = new Vector3(x * speed, rigidbody.velocity.y, rigidbody.velocity.z);
        }
        if (start == false)
        {
            rigidbody.velocity = new Vector3(0, 0, 0);
            BackGround.GetComponent<BackgroundScroller>().start = false;
        }
        speed = speed + AccelerationFactor;
    }
}
