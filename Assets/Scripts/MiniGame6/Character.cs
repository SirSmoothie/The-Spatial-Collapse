using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float x = 1f;
    public float speed = 1f;

    public bool start = false;

    public Rigidbody rigidbody;
    public CharacterSkills characterSkills;
    public GameObject Text;

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
        if (Input.GetKeyDown("space"))
        {
            start = true;
            Text.SetActive(false);
        }
        if(start == true)
        {
            rigidbody.velocity = new Vector3(x * speed, rigidbody.velocity.y, rigidbody.velocity.z);
        }
        if(start == false)
        {
            rigidbody.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown("w") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
            Jumping(true);
        }
        if (Input.GetKeyDown("a") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
            Hiding(true);
        }
        if (Input.GetKeyDown("s") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
            Sliding(true);
        }
        if (Input.GetKeyDown("d") && AbilityCoolDownTimer <= 0)
        {
            AbilityCoolDownTimer = AbilityCoolDown;
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
    }
}
