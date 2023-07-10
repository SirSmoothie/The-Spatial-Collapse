using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyController : MonoBehaviour
{
    public bool FriendlyHit = false;
    public float Health = 0f;
    public ShootingController shootingController;
    public void FriendlyDamage(float damage)
    {
        Health -= damage;
        if (Health <= -0f)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
