using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyController : MonoBehaviour
{
    public bool FriendlyHit = false;
    public float Health = 0f;
    public ShootingController shootingController;
    public AudioManager2 audioManager2;
    public void FriendlyDamage(float damage)
    {
        Health -= damage;
        if (Health <= -0f)
        {
            Destroy(gameObject);
            audioManager2.Dead();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
